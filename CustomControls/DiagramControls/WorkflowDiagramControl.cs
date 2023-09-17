using JadeChem.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace JadeChem.CustomControls.DiagramControls
{
    public partial class WorkflowDiagramControl : UserControl
    {
        #region Fields
        // Blocks in diagram
        private readonly Rectangle inputDataBlock;
        private readonly Rectangle processedDataBlock;
        private readonly Arrow processDataArrow;
        private readonly Rectangle trainDatasetBlock;
        private readonly Rectangle testDatasetBlock;
        private readonly SplitArrow trainTestSplitArrow;
        private readonly GraphicsPath modelBlockPath;
        private readonly Rectangle modelBlockBound;
        private readonly Region modelBlock;
        private readonly Rectangle evaluationBlock;
        private readonly Rectangle predictionBlock;
        private readonly Arrow trainArrow;
        private readonly Arrow testArrow1;
        private readonly Arrow testArrow2;
        private readonly Arrow predictArrow;

        // Flags
        private bool isInputDataBlockHovered = false;
        private bool isProcessedDataBlockHovered = false;
        private bool isProcessDataArrowHovered = false;
        private bool isTrainDatasetBlockHovered = false;
        private bool isTestDatasetBlockHovered = false;
        private bool isTrainTestSplitArrowHovered = false;
        private bool isModelBlockHovered = false;
        private bool isEvaluationBlockHovered = false;
        private bool isPredictionBlockHovered = false;
        private bool isTrainArrowHovered = false;
        private bool isTestArrow1Hovered = false;
        private bool isTestArrow2Hovered = false;
        private bool isPredictArrowHovered = false;

        private bool isInputDataLoaded = false;
        private bool isProcessedDataLoaded = false;
        private bool isTrainDatasetLoaded = false;
        private bool isTestDatasetLoaded = false;
        private bool isModelLoaded = false;
        private bool isModelTrained = false;
        private bool isModelEvaluated = false;

        // Pens and brushes for drawing
        private readonly Pen normalPen = new(Color.Black, 2);
        private readonly Pen highlightPen = new(Color.LightGreen, 2);
        private readonly Pen outlinePen = new(Color.LimeGreen, 3);
        private readonly Pen dashedOutlinePen = new(Color.LimeGreen, 3) { DashStyle = DashStyle.Dash };
        private readonly SolidBrush fillBrush1 = new(Color.LightBlue); // for datasets
        private readonly SolidBrush fillBrush2 = new(Color.Orange); // for model
        private readonly SolidBrush fillBrush3 = new(Color.Magenta); // for evaluation
        private readonly SolidBrush fillBrush4 = new(Color.Cyan); // for prediction
        private readonly SolidBrush normalArrowBrush = new(Color.Black);
        private readonly SolidBrush highlightBrush = new(Color.LightGreen);
        private readonly Brush textBrush = Brushes.Black;
        #endregion

        #region Events
        public delegate void InputDataBlockClickedEventHandler(object sender, EventArgs e);
        public event InputDataBlockClickedEventHandler InputDataBlockClicked;
        public delegate void ProcessingArrowBlockClickedEventHandler(object sender, EventArgs e);
        public event ProcessingArrowBlockClickedEventHandler ProcessingArrowBlockClicked;
        public delegate void ProcessedDataBlockClickedEventHandler(object sender, EventArgs e);
        public event ProcessedDataBlockClickedEventHandler ProcessedDataBlockClicked;
        public delegate void TrainDatasetBlockClickedEventHandler(object sender, EventArgs e);
        public event TrainDatasetBlockClickedEventHandler TrainDatasetBlockClicked;
        public delegate void TestDatasetBlockClickedEventHandler(object sender, EventArgs e);
        public event TestDatasetBlockClickedEventHandler TestDatasetBlockClicked;
        public delegate void ModelBlockClickedEventHandler(object sender, EventArgs e);
        public event ModelBlockClickedEventHandler ModelBlockClicked;
        public delegate void EvaluationBlockClickedEventHandler(object sender, EventArgs e);
        public event EvaluationBlockClickedEventHandler EvaluationBlockClicked;
        public delegate void PredictionBlockClickedEventHandler(object sender, EventArgs e);
        public event PredictionBlockClickedEventHandler PredictionBlockClicked;
        #endregion

        #region Constructor
        public WorkflowDiagramControl()
        {
            InitializeComponent();

            // Enable double buffering for the diagramPanel
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, diagramPanel, new object[] { true });

            // Initialize the dataset blocks
            int margin = 10;
            inputDataBlock = new Rectangle(margin, margin, 100, 50);
            processedDataBlock = new Rectangle(inputDataBlock.Right + 90, margin, 100, 50);
            trainDatasetBlock = new Rectangle(processedDataBlock.Right + 100, margin, 100, 50);
            testDatasetBlock = new Rectangle(processedDataBlock.Right + 100, trainDatasetBlock.Bottom + 15, 100, 50);

            // Initialize the model block
            modelBlockBound = new Rectangle(trainDatasetBlock.Right + 60, margin, 100, 50);
            float radius = 10;
            modelBlockPath = Drawing.Drawing.GetRoundedRectanglePath(modelBlockBound, radius);
            modelBlock = new Region(modelBlockPath);

            // Initialize the evaluation block
            evaluationBlock = new Rectangle(testDatasetBlock.Right + 60, testDatasetBlock.Top, 100, 50);

            // Initialize the prediction block
            predictionBlock = new Rectangle(modelBlockBound.Right + 60, margin, 100, 50);
            
            // Initialize the arrows
            processDataArrow = new Arrow(new Point(inputDataBlock.Right, inputDataBlock.Top + inputDataBlock.Height / 2),
                                 new Point(processedDataBlock.Left, processedDataBlock.Top + processedDataBlock.Height / 2));
            trainTestSplitArrow = new SplitArrow(new Point(processedDataBlock.Right, processedDataBlock.Top + processedDataBlock.Height / 2),
                                new Point(trainDatasetBlock.Left, trainDatasetBlock.Top + trainDatasetBlock.Height / 2),
                                new Point(testDatasetBlock.Left, testDatasetBlock.Top + testDatasetBlock.Height / 2));
            trainArrow = new Arrow(new Point(trainDatasetBlock.Right, trainDatasetBlock.Top + trainDatasetBlock.Height / 2),
                                 new Point(modelBlockBound.Left, modelBlockBound.Top + modelBlockBound.Height / 2));
            testArrow1 = new Arrow(new Point(modelBlockBound.Left + modelBlockBound.Width / 2, modelBlockBound.Bottom),
                                 new Point(evaluationBlock.Left + evaluationBlock.Width / 2, evaluationBlock.Top));
            testArrow2 = new Arrow(new Point(testDatasetBlock.Right, testDatasetBlock.Top + testDatasetBlock.Height / 2),
                                 new Point(evaluationBlock.Left, evaluationBlock.Top + evaluationBlock.Height / 2));
            predictArrow = new Arrow(new Point(modelBlockBound.Right, modelBlockBound.Top + modelBlockBound.Height / 2),
                                 new Point(predictionBlock.Left, predictionBlock.Top + predictionBlock.Height / 2));
        }
        #endregion

        #region Methods
        private void DiagramPanel_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object for drawing on the panel
            Graphics g = e.Graphics;

            // Draw the inputDataBlock with highlight if hovered
            if (isInputDataBlockHovered)
            {
                g.FillRectangle(highlightBrush, inputDataBlock);
            }
            else
            {
                g.FillRectangle(fillBrush1, inputDataBlock);
            }
            g.DrawString("Input data", Font, textBrush, inputDataBlock, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            if (isInputDataLoaded)
            {
                g.DrawRectangle(outlinePen, inputDataBlock);
            }

            // Draw the processedDataBlock with highlight if hovered
            if (isProcessedDataBlockHovered)
            {
                g.FillRectangle(highlightBrush, processedDataBlock);
            }
            else
            {
                g.FillRectangle(fillBrush1, processedDataBlock);
            }
            g.DrawString("Processed data", Font, textBrush, processedDataBlock, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            if (isProcessedDataLoaded)
            {
                g.DrawRectangle(outlinePen, processedDataBlock);
            }

            // Draw the processDataArrow with highlight if hovered
            if (isProcessDataArrowHovered)
            {
                Drawing.Drawing.DrawArrow(g, highlightPen, highlightBrush, processDataArrow);
            }
            else
            {
                Drawing.Drawing.DrawArrow(g, normalPen, normalArrowBrush, processDataArrow);
            }
            Point processingTextPoint = new((processDataArrow.StartPoint.X + processDataArrow.EndPoint.X) / 2, processDataArrow.StartPoint.Y - 20);
            g.DrawString("processing", Font, textBrush, processingTextPoint, new StringFormat { Alignment = StringAlignment.Center });

            // Draw trainDatasetBlock with highlight if hovered
            if (isTrainDatasetBlockHovered)
            {
                g.FillRectangle(highlightBrush, trainDatasetBlock);
            }
            else
            {
                g.FillRectangle(fillBrush1, trainDatasetBlock);
            }
            g.DrawString("Train Dataset", Font, textBrush, trainDatasetBlock, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            if (isTrainDatasetLoaded)
            {
                g.DrawRectangle(outlinePen, trainDatasetBlock);
            }

            // Draw testDatasetBlock with highlight if hovered
            if (isTestDatasetBlockHovered)
            {
                g.FillRectangle(highlightBrush, testDatasetBlock);
            }
            else
            {
                g.FillRectangle(fillBrush1, testDatasetBlock);
            }
            g.DrawString("Test Dataset", Font, textBrush, testDatasetBlock, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            if (isTestDatasetLoaded)
            {
                g.DrawRectangle(outlinePen, testDatasetBlock);
            }

            // Draw the trainTestSplitArrow with highlight if hovered
            if (isTrainTestSplitArrowHovered)
            {
                Drawing.Drawing.DrawSplitArrow(g, highlightPen, highlightBrush, trainTestSplitArrow);
            }
            else
            {
                Drawing.Drawing.DrawSplitArrow(g, normalPen, normalArrowBrush, trainTestSplitArrow);
            }
            Point trainTestSplitTextPoint = new((trainTestSplitArrow.StartPoint.X + trainTestSplitArrow.SplitPoint1.X) / 2, trainTestSplitArrow.StartPoint.Y - 20);
            e.Graphics.DrawString("train-test split", Font, textBrush, trainTestSplitTextPoint, new StringFormat { Alignment = StringAlignment.Center });

            // Draw the modelBlock with highlight if hovered
            if (isModelBlockHovered)
            {
                e.Graphics.FillRegion(highlightBrush, modelBlock);
            }
            else
            {
                e.Graphics.FillRegion(fillBrush2, modelBlock);
            }
            g.DrawString("Model", Font, textBrush, modelBlockBound, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            if (isModelLoaded && !isModelTrained)
            {
                g.DrawPath(dashedOutlinePen, modelBlockPath);
            }
            if (isModelTrained)
            {
                g.DrawPath(outlinePen, modelBlockPath);
            }

            // Draw the trainArrow with highlight if hovered
            if (isTrainArrowHovered)
            {
                Drawing.Drawing.DrawArrow(g, highlightPen, highlightBrush, trainArrow);
            }
            else
            {
                Drawing.Drawing.DrawArrow(g, normalPen, normalArrowBrush, trainArrow);
            }
            Point trainTextPoint = new((trainArrow.StartPoint.X + trainArrow.EndPoint.X) / 2, trainArrow.StartPoint.Y - 20);
            g.DrawString("train", Font, textBrush, trainTextPoint, new StringFormat { Alignment = StringAlignment.Center });

            // Draw the evaluationBlock with highlight if hovered
            if (isEvaluationBlockHovered)
            {
                e.Graphics.FillRectangle(highlightBrush, evaluationBlock);
            }
            else
            {
                e.Graphics.FillRectangle(fillBrush3, evaluationBlock);
            }
            g.DrawString("Evaluation", Font, textBrush, evaluationBlock, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            if (isModelEvaluated)
            {
                g.DrawRectangle(outlinePen, evaluationBlock);
            }

            // Draw the testArrow1 and testArrow1 with highlight if hovered
            if (isTestArrow1Hovered)
            {
                Drawing.Drawing.DrawArrow(g, highlightPen, highlightBrush, testArrow1);
            }
            else
            {
                Drawing.Drawing.DrawArrow(g, normalPen, normalArrowBrush, testArrow1);
            }
            if (isTestArrow2Hovered)
            {
                Drawing.Drawing.DrawArrow(g, highlightPen, highlightBrush, testArrow2);
            }
            else
            {
                Drawing.Drawing.DrawArrow(g, normalPen, normalArrowBrush, testArrow2);
            }
            Point testTextPoint = new((testArrow2.StartPoint.X + testArrow2.EndPoint.X) / 2, testArrow2.StartPoint.Y - 20);
            g.DrawString("test", Font, textBrush, testTextPoint, new StringFormat { Alignment = StringAlignment.Center });

            // Draw the predictionBlock with highlight if hovered
            if (isPredictionBlockHovered)
            {
                e.Graphics.FillRectangle(highlightBrush, predictionBlock);
            }
            else
            {
                e.Graphics.FillRectangle(fillBrush4, predictionBlock);
            }
            g.DrawString("Prediction", Font, textBrush, predictionBlock, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            // Draw the predictArrow with highlight if hovered
            if (isPredictArrowHovered)
            {
                Drawing.Drawing.DrawArrow(g, highlightPen, highlightBrush, predictArrow);
            }
            else
            {
                Drawing.Drawing.DrawArrow(g, normalPen, normalArrowBrush, predictArrow);
            }
            Point predictTextPoint = new((predictArrow.StartPoint.X + predictArrow.EndPoint.X) / 2, predictArrow.StartPoint.Y - 20);
            g.DrawString("predict", Font, textBrush, predictTextPoint, new StringFormat { Alignment = StringAlignment.Center });
        }

        private void DiagramPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point adjustedMousePos = new(e.Location.X, e.Location.Y - 5);

            isInputDataBlockHovered = inputDataBlock.Contains(adjustedMousePos);
            isProcessedDataBlockHovered = processedDataBlock.Contains(adjustedMousePos);
            isTrainDatasetBlockHovered = trainDatasetBlock.Contains(adjustedMousePos);
            isTestDatasetBlockHovered = testDatasetBlock.Contains(adjustedMousePos);
            isModelBlockHovered = modelBlock.IsVisible(adjustedMousePos);
            isEvaluationBlockHovered = evaluationBlock.Contains(adjustedMousePos);
            isPredictionBlockHovered = predictionBlock.Contains(adjustedMousePos);

            GraphicsPath processDataArrowPath = new();
            processDataArrowPath.AddLine(processDataArrow.StartPoint, processDataArrow.EndPoint);
            isProcessDataArrowHovered = processDataArrowPath.IsOutlineVisible(adjustedMousePos, new Pen(Color.Black, 10));

            GraphicsPath splitArrowPath = new();
            splitArrowPath.AddLine(trainTestSplitArrow.StartPoint, trainTestSplitArrow.SplitPoint1);
            splitArrowPath.AddLine(trainTestSplitArrow.StartPoint, trainTestSplitArrow.SplitPoint2);
            isTrainTestSplitArrowHovered = splitArrowPath.IsOutlineVisible(adjustedMousePos, new Pen(Color.Black, 10));

            GraphicsPath trainArrowPath = new();
            trainArrowPath.AddLine(trainArrow.StartPoint, trainArrow.EndPoint);
            isTrainArrowHovered = trainArrowPath.IsOutlineVisible(adjustedMousePos, new Pen(Color.Black, 10));

            GraphicsPath testArrow1Path = new();
            testArrow1Path.AddLine(testArrow1.StartPoint, testArrow1.EndPoint);
            isTestArrow1Hovered = testArrow1Path.IsOutlineVisible(adjustedMousePos, new Pen(Color.Black, 10));

            GraphicsPath testArrow2Path = new();
            testArrow2Path.AddLine(testArrow2.StartPoint, testArrow2.EndPoint);
            isTestArrow2Hovered = testArrow2Path.IsOutlineVisible(adjustedMousePos, new Pen(Color.Black, 10));

            GraphicsPath predictArrowPath = new();
            predictArrowPath.AddLine(predictArrow.StartPoint, predictArrow.EndPoint);
            isPredictArrowHovered = predictArrowPath.IsOutlineVisible(adjustedMousePos, new Pen(Color.Black, 10));

            diagramPanel.Invalidate();
        }

        private void DiagramPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (isInputDataBlockHovered)
            {
                // Raise the event
                InputDataBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }
            else if (isProcessDataArrowHovered)
            {
                // Raise the event
                ProcessingArrowBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }
            else if (isProcessedDataBlockHovered || isTrainTestSplitArrowHovered)
            {
                // Raise the event
                ProcessedDataBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }
            else if (isTrainDatasetBlockHovered)
            {
                // Raise the event
                TrainDatasetBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }
            else if (isTestDatasetBlockHovered)
            {
                // Raise the event
                TestDatasetBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }
            else if (isTrainArrowHovered || isModelBlockHovered)
            {
                // Raise the event
                ModelBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }
            else if (isTestArrow1Hovered || isTestArrow2Hovered || isEvaluationBlockHovered)
            {
                // Raise the event
                EvaluationBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }
            else if (isPredictArrowHovered || isPredictionBlockHovered)
            {
                // Raise the event
                PredictionBlockClicked?.Invoke(inputDataBlock, EventArgs.Empty);
            }

            diagramPanel.Invalidate();
        }

        public void DrawInputDataBlockOutlines(bool isInputDataLoaded)
        {
            this.isInputDataLoaded = isInputDataLoaded;
        }

        public void DrawTrainDatasetBlockOutlines(bool isTrainDatasetLoaded)
        {
            this.isTrainDatasetLoaded = isTrainDatasetLoaded;
        }

        public void DrawTestDatasetBlockOutlines(bool isTestDatasetLoaded)
        {
            this.isTestDatasetLoaded = isTestDatasetLoaded;
        }

        public void DrawProcessDataBlockOutlines(bool isProcessedDataLoaded)
        {
            this.isProcessedDataLoaded = isProcessedDataLoaded;
        }

        public void DrawModelBlockDashedOutlines(bool isModelLoaded)
        {
            this.isModelLoaded = isModelLoaded;
            isModelTrained = false;
        }

        public void DrawModelBlockOutlines(bool isModelTrained)
        {
            this.isModelTrained = isModelTrained;
        }

        public void DrawEvaluationBlockOutlines(bool isModelEvaluated)
        {
            this.isModelEvaluated = isModelEvaluated;
        }
        #endregion
    }
}
