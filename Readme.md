# JadeML
A GUI software for simple machine learning (ML) tasks in Windows.
## Features
![Main window](/images/main-window.png "Main window")
- Graphical user interface with flow diagram for each ML task
- MDI application, multiple ML tasks can be run at a time
- Testing and making prediction using trained models
- Save and load ML tasks
- Graphical support for common ML models

![Artificial neural network](/images/artificial-neural-network.png "Artificial neural network")
*(artificial neural network model)*

![Decision tree](/images/decision-tree.png "Decision tree")
*(decision tree model)*

![k-means](/images/k-means.png "k-means")
*(k-means model)*

## Download and install
- Visit our release page and download the latest installer
- Run the installer
## How to prepare the dataset
***For supervised learning tasks***: the dataset must contain one or more input columns and one output column, which must be placed at the last position. All input data must be numeric. Output data must be categorical for classification, or continuous for regression.

***For unsupervised learning tasks***: the dataset must contain one or more input columns. All input data must be numeric.


## Supported models
#### Classification and Regression
  - Logistic Regression
  - k-Nearest Neighbors
  - Minimum Mean Distance
  - Naive Bayes
  - Decision Tree
  - Random Forest
  - Linear Regression
  - Polynomial Regression
  - Support Vector Machine (SVM)
  - Artificial Neural Network
#### Clustering
  - k-Means
  - k-Medoids
  - Binary Split
  - Gaussian Mixture
  - Mean-Shift
#### Dimensionality Reduction
  - Principle Component Analysis
  - Discriminant Analysis

  *** The ML models in this software are from [Accord.net](http://accord-framework.net/) framework.