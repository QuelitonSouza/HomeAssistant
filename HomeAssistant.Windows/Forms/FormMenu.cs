﻿using HomeAssistant.Windows.Dto;
using HomeAssistant.Windows.Enums;
using HomeAssistant.Windows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssistant.Windows.Forms
{
	public partial class FormMenu : Form
	{
		private bool Filtrar = true;
		public FormMenu()
		{
			InitializeComponent();
			LoadConfigs();
		}


		private void ReadLog_Click(object sender, EventArgs e)
		{
			try
			{
				var resultLog = new WriterAndReadConfigs().ReadLogs();

				if(Filtrar)
				{
					Filtrar = false;
					var filtro = txtFiltrar.Text.ToLower();
					resultLog = resultLog.Where(x => x.Message.ToLower().Contains(filtro)).ToList();
				}

				this.DataGridLog.DataSource = resultLog.OrderByDescending(x => x.DateLog).ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Erro", MessageBoxButtons.OK);
			}
		}

		private void LoadConfigs()
		{
			try
			{
				var resultConfigs = new WriterAndReadConfigs().ReadConfigs();
				txtUsuario.Text = resultConfigs.UserName;
				txtSenha.Text = resultConfigs.Password;
				txtLigar.Text = (resultConfigs.BatteryLifePercentLow * 100).ToString();
				txtDesligar.Text = (resultConfigs.BatteryLifePercentHigh * 100).ToString();

				cbxStatus.DataSource = Enum.GetValues(typeof(StatusDeviceEnum));
				cbxStatus.SelectedItem = resultConfigs.LastStateDevice;

				btnTestar.Text = resultConfigs.LastStateDevice == StatusDeviceEnum.off ? "Ligar":  "Desligar";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Erro", MessageBoxButtons.OK);
			}
		}

		private void txtLigar_TextChanged(object sender, EventArgs e)
		{
			Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$");
			Match m = r.Match(txtLigar.Text);
			if (m.Success)
			{
				txtLigar.Text = txtLigar.Text;
			}
			else
			{
				txtLigar.Text = "";
			}
		}

		private void txtDesligar_TextChanged(object sender, EventArgs e)
		{
			Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$");
			Match m = r.Match(txtLigar.Text);
			if (m.Success)
			{
				txtLigar.Text = txtLigar.Text;
			}
			else
			{
				txtLigar.Text = "";
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				var dtoConfigs = new DtoConfigs();
				dtoConfigs.UserName = txtUsuario.Text;
				dtoConfigs.Password = txtSenha.Text;
				dtoConfigs.BatteryLifePercentLow = float.Parse(txtLigar.Text) / 100;
				dtoConfigs.BatteryLifePercentHigh = float.Parse(txtDesligar.Text) / 100;
				dtoConfigs.LastStateDevice = (StatusDeviceEnum)cbxStatus.SelectedItem;

				new WriterAndReadConfigs().WriterConfigs(dtoConfigs);
				Thread.Sleep(TimeSpan.FromSeconds(2));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Erro", MessageBoxButtons.OK);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				if(btnTestar.Text == "Ligar")
				{
					new ChangeStatusService().ChangeStatusSwitch(StatusDeviceEnum.on);
					cbxStatus.SelectedItem = StatusDeviceEnum.on;
					btnTestar.Text = "Desligar";
					
					return;
				}

				if (btnTestar.Text == "Desligar")
				{
					new ChangeStatusService().ChangeStatusSwitch(StatusDeviceEnum.off);
					cbxStatus.SelectedItem = StatusDeviceEnum.off;
					btnTestar.Text = "Ligar";
					
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Erro", MessageBoxButtons.OK);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			Filtrar = true;
			ReadLog_Click(sender, e);
		}
	}
}