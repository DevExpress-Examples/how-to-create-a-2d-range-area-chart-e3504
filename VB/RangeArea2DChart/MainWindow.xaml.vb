﻿Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace RangeArea2DChart
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ChartViewModel
'INSTANT VB NOTE: The field dataPoints was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private dataPoints_Conflict As List(Of DataPoint)
		Public ReadOnly Property DataPoints() As List(Of DataPoint)
			Get
				If dataPoints_Conflict Is Nothing Then
					dataPoints_Conflict = New List(Of DataPoint) From {
						New DataPoint(New DateTime(2019, 1, 1), 7.2, 2.7),
						New DataPoint(New DateTime(2019, 2, 1), 8.3, 2.8),
						New DataPoint(New DateTime(2019, 3, 1), 12.2, 5.3),
						New DataPoint(New DateTime(2019, 4, 1), 15.6, 7.3),
						New DataPoint(New DateTime(2019, 5, 1), 19.6, 10.9),
						New DataPoint(New DateTime(2019, 6, 1), 22.7, 13.8),
						New DataPoint(New DateTime(2019, 7, 1), 25.2, 15.8),
						New DataPoint(New DateTime(2019, 8, 1), 25, 15.7),
						New DataPoint(New DateTime(2019, 9, 1), 21.1, 12.7),
						New DataPoint(New DateTime(2019, 10, 1), 16.3, 9.6),
						New DataPoint(New DateTime(2019, 11, 1), 10.8, 5.8),
						New DataPoint(New DateTime(2019, 12, 1), 7.5, 3.4)
					}
				End If
				Return dataPoints_Conflict
			End Get
		End Property
	End Class
	Public Class DataPoint
		Public Property Time() As DateTime
		Public Property Value1() As Double
		Public Property Value2() As Double
'INSTANT VB NOTE: The variable time was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable value1 was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable value2 was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal time_Conflict As DateTime, ByVal value1_Conflict As Double, ByVal value2_Conflict As Double)
			Me.Time = time_Conflict
			Me.Value1 = value1_Conflict
			Me.Value2 = value2_Conflict
		End Sub
	End Class
End Namespace
