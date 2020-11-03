namespace HomeAssistant.Windows.Forms
{
	partial class FormMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.txtFiltrar = new System.Windows.Forms.TextBox();
			this.DataGridLog = new System.Windows.Forms.DataGridView();
			this.ReadLog = new System.Windows.Forms.Button();
			this.tabConfigs = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnTestar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDesligar = new System.Windows.Forms.Label();
			this.txtLigar = new System.Windows.Forms.TextBox();
			this.lblMinBateria = new System.Windows.Forms.Label();
			this.cbxStatus = new System.Windows.Forms.ComboBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtDesligar = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tabGraficos = new System.Windows.Forms.TabPage();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dtoChartOffBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dtoChartOnBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridLog)).BeginInit();
			this.tabConfigs.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabGraficos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtoChartOffBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtoChartOnBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabConfigs);
			this.tabControl1.Controls.Add(this.tabGraficos);
			this.tabControl1.Location = new System.Drawing.Point(1, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(514, 379);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnFiltrar);
			this.tabPage1.Controls.Add(this.txtFiltrar);
			this.tabPage1.Controls.Add(this.DataGridLog);
			this.tabPage1.Controls.Add(this.ReadLog);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(506, 353);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Log";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Location = new System.Drawing.Point(421, 9);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
			this.btnFiltrar.TabIndex = 3;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = true;
			this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
			// 
			// txtFiltrar
			// 
			this.txtFiltrar.Location = new System.Drawing.Point(203, 9);
			this.txtFiltrar.Name = "txtFiltrar";
			this.txtFiltrar.Size = new System.Drawing.Size(212, 20);
			this.txtFiltrar.TabIndex = 2;
			// 
			// DataGridLog
			// 
			this.DataGridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridLog.Location = new System.Drawing.Point(7, 35);
			this.DataGridLog.Name = "DataGridLog";
			this.DataGridLog.Size = new System.Drawing.Size(489, 312);
			this.DataGridLog.TabIndex = 1;
			// 
			// ReadLog
			// 
			this.ReadLog.Location = new System.Drawing.Point(7, 6);
			this.ReadLog.Name = "ReadLog";
			this.ReadLog.Size = new System.Drawing.Size(75, 23);
			this.ReadLog.TabIndex = 0;
			this.ReadLog.Text = "Ler Log";
			this.ReadLog.UseVisualStyleBackColor = true;
			this.ReadLog.Click += new System.EventHandler(this.ReadLog_Click);
			// 
			// tabConfigs
			// 
			this.tabConfigs.Controls.Add(this.panel2);
			this.tabConfigs.Controls.Add(this.lblDesligar);
			this.tabConfigs.Controls.Add(this.txtLigar);
			this.tabConfigs.Controls.Add(this.lblMinBateria);
			this.tabConfigs.Controls.Add(this.cbxStatus);
			this.tabConfigs.Controls.Add(this.lblStatus);
			this.tabConfigs.Controls.Add(this.txtSenha);
			this.tabConfigs.Controls.Add(this.lblSenha);
			this.tabConfigs.Controls.Add(this.txtUsuario);
			this.tabConfigs.Controls.Add(this.lblUsuario);
			this.tabConfigs.Controls.Add(this.panel1);
			this.tabConfigs.Location = new System.Drawing.Point(4, 22);
			this.tabConfigs.Name = "tabConfigs";
			this.tabConfigs.Padding = new System.Windows.Forms.Padding(3);
			this.tabConfigs.Size = new System.Drawing.Size(506, 353);
			this.tabConfigs.TabIndex = 1;
			this.tabConfigs.Text = "Configurações";
			this.tabConfigs.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.btnTestar);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(249, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(241, 228);
			this.panel2.TabIndex = 12;
			// 
			// btnTestar
			// 
			this.btnTestar.Location = new System.Drawing.Point(69, 62);
			this.btnTestar.Name = "btnTestar";
			this.btnTestar.Size = new System.Drawing.Size(100, 81);
			this.btnTestar.TabIndex = 1;
			this.btnTestar.Text = "button1";
			this.btnTestar.UseVisualStyleBackColor = true;
			this.btnTestar.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Teste";
			// 
			// lblDesligar
			// 
			this.lblDesligar.AutoSize = true;
			this.lblDesligar.Location = new System.Drawing.Point(8, 166);
			this.lblDesligar.Name = "lblDesligar";
			this.lblDesligar.Size = new System.Drawing.Size(56, 13);
			this.lblDesligar.TabIndex = 9;
			this.lblDesligar.Text = "% Desligar";
			// 
			// txtLigar
			// 
			this.txtLigar.Location = new System.Drawing.Point(8, 142);
			this.txtLigar.Name = "txtLigar";
			this.txtLigar.Size = new System.Drawing.Size(223, 20);
			this.txtLigar.TabIndex = 8;
			this.txtLigar.TextChanged += new System.EventHandler(this.txtLigar_TextChanged);
			// 
			// lblMinBateria
			// 
			this.lblMinBateria.AutoSize = true;
			this.lblMinBateria.Location = new System.Drawing.Point(8, 128);
			this.lblMinBateria.Name = "lblMinBateria";
			this.lblMinBateria.Size = new System.Drawing.Size(41, 13);
			this.lblMinBateria.TabIndex = 7;
			this.lblMinBateria.Text = "% Ligar";
			// 
			// cbxStatus
			// 
			this.cbxStatus.FormattingEnabled = true;
			this.cbxStatus.Location = new System.Drawing.Point(11, 101);
			this.cbxStatus.Name = "cbxStatus";
			this.cbxStatus.Size = new System.Drawing.Size(222, 21);
			this.cbxStatus.TabIndex = 6;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(9, 88);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(64, 13);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "Status Atual";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(11, 60);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(223, 20);
			this.txtSenha.TabIndex = 3;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(10, 47);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(38, 13);
			this.lblSenha.TabIndex = 2;
			this.lblSenha.Text = "Senha";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(10, 21);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(223, 20);
			this.txtUsuario.TabIndex = 1;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(9, 8);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(43, 13);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuário";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtDesligar);
			this.panel1.Controls.Add(this.btnSalvar);
			this.panel1.Location = new System.Drawing.Point(3, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(239, 230);
			this.panel1.TabIndex = 11;
			// 
			// txtDesligar
			// 
			this.txtDesligar.Location = new System.Drawing.Point(3, 172);
			this.txtDesligar.Name = "txtDesligar";
			this.txtDesligar.Size = new System.Drawing.Size(223, 20);
			this.txtDesligar.TabIndex = 10;
			this.txtDesligar.TextChanged += new System.EventHandler(this.txtDesligar_TextChanged);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(154, 198);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 12;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// tabGraficos
			// 
			this.tabGraficos.Controls.Add(this.chart1);
			this.tabGraficos.Location = new System.Drawing.Point(4, 22);
			this.tabGraficos.Name = "tabGraficos";
			this.tabGraficos.Size = new System.Drawing.Size(506, 353);
			this.tabGraficos.TabIndex = 2;
			this.tabGraficos.Text = "Gráficos";
			this.tabGraficos.UseVisualStyleBackColor = true;
			// 
			// chart1
			// 
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
			chartArea1.BorderColor = System.Drawing.Color.Empty;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(7, 12);
			this.chart1.Name = "chart1";
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Green;
			series1.EmptyPointStyle.IsValueShownAsLabel = true;
			series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			series1.IsValueShownAsLabel = true;
			series1.LabelForeColor = System.Drawing.Color.Green;
			series1.Legend = "Legend1";
			series1.Name = "Carregando";
			series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
			series1.XValueMember = "Description";
			series1.YValueMembers = "Time";
			series2.BorderWidth = 3;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.Red;
			series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			series2.IsValueShownAsLabel = true;
			series2.LabelForeColor = System.Drawing.Color.Red;
			series2.Legend = "Legend1";
			series2.Name = "Bateria";
			series2.XValueMember = "Description";
			series2.YValueMembers = "Time";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(492, 334);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// dtoChartOffBindingSource
			// 
			this.dtoChartOffBindingSource.DataSource = typeof(HomeAssistant.Windows.Dto.DtoChartOff);
			// 
			// dtoChartOnBindingSource
			// 
			this.dtoChartOnBindingSource.DataSource = typeof(HomeAssistant.Windows.Dto.DtoChartOn);
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 380);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Configurações";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridLog)).EndInit();
			this.tabConfigs.ResumeLayout(false);
			this.tabConfigs.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabGraficos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtoChartOffBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtoChartOnBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button ReadLog;
		private System.Windows.Forms.TabPage tabConfigs;
		private System.Windows.Forms.DataGridView DataGridLog;
		private System.Windows.Forms.ComboBox cbxStatus;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtDesligar;
		private System.Windows.Forms.Label lblDesligar;
		private System.Windows.Forms.TextBox txtLigar;
		private System.Windows.Forms.Label lblMinBateria;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnTestar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.TextBox txtFiltrar;
		private System.Windows.Forms.TabPage tabGraficos;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.BindingSource dtoChartOnBindingSource;
		private System.Windows.Forms.BindingSource dtoChartOffBindingSource;
	}
}