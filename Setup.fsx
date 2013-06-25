﻿#r "PresentationCore"
#r "PresentationFramework"
#r "System"
#r "System.Core"
#r "System.Drawing"
#r "System.Numerics"
#r "System.Windows.Forms"
#r "System.Windows.Forms.DataVisualization"
#r "System.Xaml"
#r "System.Xml"
#r "UIAutomationTypes"
#r "WindowsBase"
#r "WindowsFormsIntegration"

#r "packages/MathNet.Numerics.2.5.0/lib/net40/MathNet.Numerics.dll"
#r "packages/MathNet.Numerics.FSharp.2.5.0/lib/net40/MathNet.Numerics.FSharp.dll"
#r "packages/MathNet.Numerics.2.5.0/lib/net40/MathNet.Numerics.IO.dll"
#r "packages/FSharp.Data.1.1.5/lib/net40/FSharp.Data.dll"
#r "packages/FSharp.Charting.0.82/lib/net40/FSharp.Charting.dll"
#r "libs/DynamicDataDisplay.dll"
#r "libs/Plot3D.dll"
#r "libs/WPFChart.dll"

#load "ChartWindow.fs"
#load "SurfacePlotWindow.fs"
#load "Charting.fs"
#load "Iteration.fs"
#load "MathNetExtensions.fs"
#load "LinearRegressionWithOneVariable.fs"
#load "LinearRegression.fs"
#load "LogisticRegression.fs"
#load "LinearRegressionWithRegularization.fs"
#load "LogisticRegressionWithRegularization.fs"

open FSharp.Charting
module FsiAutoShow = 
    fsi.AddPrinter(fun (ch:FSharp.Charting.ChartTypes.GenericChart) -> ch.ShowChart(); "(Chart)")