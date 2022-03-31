<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdventureWorksDataSet = New DataBAnding.AdventureWorksDataSet()
        Me.AdventureWorksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AdventureWorksDataSet1 = New DataBAnding.AdventureWorksDataSet1()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New DataBAnding.AdventureWorksDataSet1TableAdapters.EmployeeTableAdapter()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalIDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HireDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalariedFlagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VacationHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SickLeaveHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentFlagDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RowguidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModifiedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdventureWorksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        '
        'AdventureWorksDataSet
        '
        Me.AdventureWorksDataSet.DataSetName = "AdventureWorksDataSet"
        Me.AdventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdventureWorksDataSetBindingSource
        '
        Me.AdventureWorksDataSetBindingSource.DataSource = Me.AdventureWorksDataSet
        Me.AdventureWorksDataSetBindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.NationalIDNumberDataGridViewTextBoxColumn, Me.ContactIDDataGridViewTextBoxColumn, Me.LoginIDDataGridViewTextBoxColumn, Me.ManagerIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.BirthDateDataGridViewTextBoxColumn, Me.MaritalStatusDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.HireDateDataGridViewTextBoxColumn, Me.SalariedFlagDataGridViewCheckBoxColumn, Me.VacationHoursDataGridViewTextBoxColumn, Me.SickLeaveHoursDataGridViewTextBoxColumn, Me.CurrentFlagDataGridViewCheckBoxColumn, Me.RowguidDataGridViewTextBoxColumn, Me.ModifiedDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1546, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'AdventureWorksDataSet1
        '
        Me.AdventureWorksDataSet1.DataSetName = "AdventureWorksDataSet1"
        Me.AdventureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.AdventureWorksDataSet1
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIDDataGridViewTextBoxColumn.Width = 125
        '
        'NationalIDNumberDataGridViewTextBoxColumn
        '
        Me.NationalIDNumberDataGridViewTextBoxColumn.DataPropertyName = "NationalIDNumber"
        Me.NationalIDNumberDataGridViewTextBoxColumn.HeaderText = "NationalIDNumber"
        Me.NationalIDNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NationalIDNumberDataGridViewTextBoxColumn.Name = "NationalIDNumberDataGridViewTextBoxColumn"
        Me.NationalIDNumberDataGridViewTextBoxColumn.Width = 125
        '
        'ContactIDDataGridViewTextBoxColumn
        '
        Me.ContactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID"
        Me.ContactIDDataGridViewTextBoxColumn.HeaderText = "ContactID"
        Me.ContactIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactIDDataGridViewTextBoxColumn.Name = "ContactIDDataGridViewTextBoxColumn"
        Me.ContactIDDataGridViewTextBoxColumn.Width = 125
        '
        'LoginIDDataGridViewTextBoxColumn
        '
        Me.LoginIDDataGridViewTextBoxColumn.DataPropertyName = "LoginID"
        Me.LoginIDDataGridViewTextBoxColumn.HeaderText = "LoginID"
        Me.LoginIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LoginIDDataGridViewTextBoxColumn.Name = "LoginIDDataGridViewTextBoxColumn"
        Me.LoginIDDataGridViewTextBoxColumn.Width = 125
        '
        'ManagerIDDataGridViewTextBoxColumn
        '
        Me.ManagerIDDataGridViewTextBoxColumn.DataPropertyName = "ManagerID"
        Me.ManagerIDDataGridViewTextBoxColumn.HeaderText = "ManagerID"
        Me.ManagerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ManagerIDDataGridViewTextBoxColumn.Name = "ManagerIDDataGridViewTextBoxColumn"
        Me.ManagerIDDataGridViewTextBoxColumn.Width = 125
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 125
        '
        'BirthDateDataGridViewTextBoxColumn
        '
        Me.BirthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate"
        Me.BirthDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn"
        Me.BirthDateDataGridViewTextBoxColumn.Width = 125
        '
        'MaritalStatusDataGridViewTextBoxColumn
        '
        Me.MaritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus"
        Me.MaritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus"
        Me.MaritalStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaritalStatusDataGridViewTextBoxColumn.Name = "MaritalStatusDataGridViewTextBoxColumn"
        Me.MaritalStatusDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'HireDateDataGridViewTextBoxColumn
        '
        Me.HireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate"
        Me.HireDateDataGridViewTextBoxColumn.HeaderText = "HireDate"
        Me.HireDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HireDateDataGridViewTextBoxColumn.Name = "HireDateDataGridViewTextBoxColumn"
        Me.HireDateDataGridViewTextBoxColumn.Width = 125
        '
        'SalariedFlagDataGridViewCheckBoxColumn
        '
        Me.SalariedFlagDataGridViewCheckBoxColumn.DataPropertyName = "SalariedFlag"
        Me.SalariedFlagDataGridViewCheckBoxColumn.HeaderText = "SalariedFlag"
        Me.SalariedFlagDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.SalariedFlagDataGridViewCheckBoxColumn.Name = "SalariedFlagDataGridViewCheckBoxColumn"
        Me.SalariedFlagDataGridViewCheckBoxColumn.Width = 125
        '
        'VacationHoursDataGridViewTextBoxColumn
        '
        Me.VacationHoursDataGridViewTextBoxColumn.DataPropertyName = "VacationHours"
        Me.VacationHoursDataGridViewTextBoxColumn.HeaderText = "VacationHours"
        Me.VacationHoursDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VacationHoursDataGridViewTextBoxColumn.Name = "VacationHoursDataGridViewTextBoxColumn"
        Me.VacationHoursDataGridViewTextBoxColumn.Width = 125
        '
        'SickLeaveHoursDataGridViewTextBoxColumn
        '
        Me.SickLeaveHoursDataGridViewTextBoxColumn.DataPropertyName = "SickLeaveHours"
        Me.SickLeaveHoursDataGridViewTextBoxColumn.HeaderText = "SickLeaveHours"
        Me.SickLeaveHoursDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SickLeaveHoursDataGridViewTextBoxColumn.Name = "SickLeaveHoursDataGridViewTextBoxColumn"
        Me.SickLeaveHoursDataGridViewTextBoxColumn.Width = 125
        '
        'CurrentFlagDataGridViewCheckBoxColumn
        '
        Me.CurrentFlagDataGridViewCheckBoxColumn.DataPropertyName = "CurrentFlag"
        Me.CurrentFlagDataGridViewCheckBoxColumn.HeaderText = "CurrentFlag"
        Me.CurrentFlagDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.CurrentFlagDataGridViewCheckBoxColumn.Name = "CurrentFlagDataGridViewCheckBoxColumn"
        Me.CurrentFlagDataGridViewCheckBoxColumn.Width = 125
        '
        'RowguidDataGridViewTextBoxColumn
        '
        Me.RowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.HeaderText = "rowguid"
        Me.RowguidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RowguidDataGridViewTextBoxColumn.Name = "RowguidDataGridViewTextBoxColumn"
        Me.RowguidDataGridViewTextBoxColumn.Width = 125
        '
        'ModifiedDateDataGridViewTextBoxColumn
        '
        Me.ModifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate"
        Me.ModifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate"
        Me.ModifiedDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ModifiedDateDataGridViewTextBoxColumn.Name = "ModifiedDateDataGridViewTextBoxColumn"
        Me.ModifiedDateDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1570, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdventureWorksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents AdventureWorksDataSetBindingSource As BindingSource
    Friend WithEvents AdventureWorksDataSet As AdventureWorksDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AdventureWorksDataSet1 As AdventureWorksDataSet1
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As AdventureWorksDataSet1TableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NationalIDNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HireDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalariedFlagDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents VacationHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SickLeaveHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentFlagDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents RowguidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModifiedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
