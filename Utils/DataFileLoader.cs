using System.Data;
using Accord.IO;
using Accord.Math;

namespace JadeChem.Utils
{
    public static class DataFileLoader
    {
        #region Method
        public static DataTable LoadCsvFile(string filePath, bool hasHeaders)
        {
            string extension = Path.GetExtension(filePath);
            if (extension == ".csv")
            {
                // Load the .csv file
                CsvReader csvReader = new(filePath, hasHeaders)
                {
                    Delimiter = ',',
                    SkipEmptyLines = true,
                    MissingFieldAction = MissingFieldAction.ReplaceByEmpty
                };
                DataTable loadedData = csvReader.ToTable();

                // Remove null row
                for (int rowIndex = 0; rowIndex < loadedData.Rows.Count; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < loadedData.Columns.Count; columnIndex++)
                        if (loadedData.Rows[rowIndex][columnIndex] == DBNull.Value || (string)loadedData.Rows[rowIndex][columnIndex] == "")
                        {
                            loadedData.Rows.Remove(loadedData.Rows[rowIndex]);
                            rowIndex--;
                        }
                }

                loadedData.AcceptChanges();

                // Check for invalid data
                if (loadedData.Columns.Count < 1 || loadedData.Rows.Count == 0)
                    throw new Exception("Invalid data!");

                // Convert number column to double type
                DataTable inputData = new();
                List<int> indicesOfNumericColumns = new();
                for (int columnIndex = 0; columnIndex < loadedData.Columns.Count; columnIndex++)
                {
                    string columnName = loadedData.Columns[columnIndex].ColumnName;

                    try
                    {
                        loadedData.Columns[columnIndex].ToArray(); // This will throw an exception if any data is not numeric
                        indicesOfNumericColumns.Add(columnIndex);
                        inputData.Columns.Add(columnName, typeof(double));
                    }
                    catch
                    {
                        inputData.Columns.Add(columnName, typeof(string));
                    }
                }
                for (int rowIndex = 0; rowIndex < loadedData.Rows.Count; rowIndex++)
                {
                    DataRow row = inputData.NewRow();
                    for (int columnIndex = 0; columnIndex < loadedData.Columns.Count; columnIndex++)
                    {
                        if (indicesOfNumericColumns.Contains(columnIndex) && loadedData.Rows[rowIndex][columnIndex] != DBNull.Value) // numeric data
                            row[columnIndex] = double.Parse((string)loadedData.Rows[rowIndex][columnIndex]);
                        else // string data
                            row[columnIndex] = (string)loadedData.Rows[rowIndex][columnIndex];
                    }
                    inputData.Rows.Add(row);
                }

                loadedData.AcceptChanges();

                // Return the data
                return inputData;
            }
            else
            {
                throw new Exception("Cannot open the selected file!");
            }
        }
        #endregion
    }
}
