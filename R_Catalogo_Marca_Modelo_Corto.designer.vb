﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_Catalogo_Marca_Modelo_Corto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_Catalogo_Marca_Modelo_Corto))
        Me.Sp_consultaLogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MELDataSet = New Tesis_Nueva.MELDataSet
        Me.sp_consultaCatalogoModelos = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Sp_consultaCatalogoModelosTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCatalogoModelosTableAdapter
        Me.Sp_consultaLogoTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
        Me.Sp_consultaCatalogoModelos_UbicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_consultaCatalogoModelos_UbicTableAdapter = New Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCatalogoModelos_UbicTableAdapter
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_consultaCatalogoModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_consultaCatalogoModelos_UbicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sp_consultaLogoBindingSource
        '
        Me.Sp_consultaLogoBindingSource.DataMember = "sp_consultaLogo"
        Me.Sp_consultaLogoBindingSource.DataSource = Me.MELDataSet
        '
        'MELDataSet
        '
        Me.MELDataSet.DataSetName = "MELDataSet"
        Me.MELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_consultaCatalogoModelos
        '
        Me.sp_consultaCatalogoModelos.DataMember = "sp_consultaCatalogoModelos"
        Me.sp_consultaCatalogoModelos.DataSource = Me.MELDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MELDataSet_sp_consultaLogo"
        ReportDataSource1.Value = Me.Sp_consultaLogoBindingSource
        ReportDataSource2.Name = "MELDataSet_sp_consultaCatalogoModelos"
        ReportDataSource2.Value = Me.sp_consultaCatalogoModelos
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tesis_Nueva.R_CatalogoMarcaModeloCorto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(1)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(683, 353)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sp_consultaCatalogoModelosTableAdapter
        '
        Me.Sp_consultaCatalogoModelosTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaLogoTableAdapter
        '
        Me.Sp_consultaLogoTableAdapter.ClearBeforeFill = True
        '
        'Sp_consultaCatalogoModelos_UbicBindingSource
        '
        Me.Sp_consultaCatalogoModelos_UbicBindingSource.DataMember = "sp_consultaCatalogoModelos_Ubic"
        Me.Sp_consultaCatalogoModelos_UbicBindingSource.DataSource = Me.MELDataSet
        '
        'Sp_consultaCatalogoModelos_UbicTableAdapter
        '
        Me.Sp_consultaCatalogoModelos_UbicTableAdapter.ClearBeforeFill = True
        '
        'R_Catalogo_Marca_Modelo_Corto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 353)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "R_Catalogo_Marca_Modelo_Corto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo"
        CType(Me.Sp_consultaLogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MELDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_consultaCatalogoModelos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_consultaCatalogoModelos_UbicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_consultaCatalogoModelos As System.Windows.Forms.BindingSource
    Friend WithEvents MELDataSet As Tesis_Nueva.MELDataSet
    Friend WithEvents Sp_consultaCatalogoModelosTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCatalogoModelosTableAdapter
    Friend WithEvents Sp_consultaLogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaLogoTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaLogoTableAdapter
    Friend WithEvents Sp_consultaCatalogoModelos_UbicBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_consultaCatalogoModelos_UbicTableAdapter As Tesis_Nueva.MELDataSetTableAdapters.sp_consultaCatalogoModelos_UbicTableAdapter
End Class
