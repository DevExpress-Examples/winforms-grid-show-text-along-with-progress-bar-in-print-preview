Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.button1 = New System.Windows.Forms.Button()
			Me.productsTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.repositoryItemProgressBar1 = New WindowsApplication1.MyProgressBarControl.RepositoryItemMyProgressBarControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.productsBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(8,8)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1})
			Me.gridControl1.Size = New System.Drawing.Size(496,296)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductName, Me.colUnitPrice, Me.colUnitsOnOrder})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 0
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 1
			' 
			' colUnitsOnOrder
			' 
			Me.colUnitsOnOrder.ColumnEdit = Me.repositoryItemProgressBar1
			Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
			Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
			Me.colUnitsOnOrder.Visible = True
			Me.colUnitsOnOrder.VisibleIndex = 2
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(224,312)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75,23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F,13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(508,337)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents button1 As System.Windows.Forms.Button
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemProgressBar1 As WindowsApplication1.MyProgressBarControl.RepositoryItemMyProgressBarControl
	End Class
End Namespace

