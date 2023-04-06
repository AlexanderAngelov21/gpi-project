using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}

		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}

		void DrawEllipseSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

			viewPort.Invalidate();
		}

		void DrawSquareSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomSquare();

			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

			viewPort.Invalidate();
		}


		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране4 на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{

			if (pickUpSpeedButton.Checked)
			{
				Shape sel = dialogProcessor.ContainsPoint(e.Location);
				if (sel != null)
				{
					if (dialogProcessor.Selection.Contains(sel))
					{
						dialogProcessor.Selection.Remove(sel);
					}
					else
					{
						dialogProcessor.Selection.Add(sel);
					}
				}

				statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
				dialogProcessor.IsDragging = true;
				dialogProcessor.LastLocation = e.Location;
				viewPort.Invalidate();

			}
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging)
			{
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		void DrawLineSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на отсечка";

			viewPort.Invalidate();
		}
		private void drawCircleButton_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomCircle();
			statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";
			viewPort.Invalidate();
		}
		private void drawPointButton_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomPoint();
			statusBar.Items[0].Text = "Последно действие: Рисуване на точка";
			viewPort.Invalidate();
		}

		void RotateButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.Rotate(angle: 45);
			viewPort.Invalidate();
			statusBar.Items[0].Text = "Последно действие: Завъртане на примитив";
		}


		private void fillColorSpeedButton_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				selectedColorTextBox.BackColor = colorDialog.Color;
				dialogProcessor.selectedFillColor = colorDialog.Color;
				dialogProcessor.SetFillColor(colorDialog.Color);
				viewPort.Invalidate();
				statusBar.Items[0].Text = "Последно действие: Смяна на цвета на запълване";
			}
		}





		private void colorDialogSpeedButton_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				strokeColorTextBox.BackColor = colorDialog.Color;
				dialogProcessor.selectedStrokeColor = colorDialog.Color;
				dialogProcessor.SetStrokeColor(colorDialog.Color);
				viewPort.Invalidate();
				statusBar.Items[0].Text = "Последно действие: Смяна на цвета на контура";

			}
		}

		private void opacityComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string opacText = opacityComboBox.Text;
			int opacValue = 255;
			switch (opacText)
			{
				case "0%":
					opacValue = 0;
					break;
				case "25%":
					opacValue = (int)(opacValue * 0.25);
					break;
				case "50%":
					opacValue = (int)(opacValue * 0.50);
					break;
				case "75%":
					opacValue = (int)(opacValue * 0.75);
					break;
			}
			dialogProcessor.selectedOpacityValue = opacValue;
			dialogProcessor.GroupOpacity(opacValue);
			statusBar.Items[0].Text = "Последно действие: Задаване на прозрачност";
			viewPort.Invalidate();
		}

		private void addRndTrapeze_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomTrapeze();

			statusBar.Items[0].Text = "Последно действие: Рисуване на трапец";

			viewPort.Invalidate();
		}

		private void GroupShapeBtn_Click(object sender, EventArgs e)
		{

			dialogProcessor.GroupSelected();
			statusBar.Items[0].Text = "Последно действие: Групиране";
			viewPort.Invalidate();

		}

		private void UngroupShapeBtn_Click(object sender, EventArgs e)
		{

			dialogProcessor.UngroupSelected();
			statusBar.Items[0].Text = "Последно действие: Разгрупиране";
			viewPort.Invalidate();
		}

		private void DeleteShapesBtn_Click(object sender, EventArgs e)
		{
			dialogProcessor.DeleteSelectedShapes();
			statusBar.Items[0].Text = "Последно действие: Изтриване на селектираните примитиви.";
			viewPort.Invalidate();
		}

        private void ResizeBtn_Click(object sender, EventArgs e)
        {
			float w;
			float h;
			try
			{
				if (!HeightTB.Text.Equals(""))
				{
					h = float.Parse(HeightTB.Text);
				}
				else
				{
					h = -1;
				}
				if (!WidthTB.Text.Equals(""))
				{
					w = float.Parse(WidthTB.Text);
				}
				else
				{
					w = -1;
				}
				dialogProcessor.Resize(w, h);
			}
			catch (Exception)
			{
				MessageBox.Show("Inserted values are not valid numbers!");
			}
			statusBar.Items[0].Text = "Последно действие: Преоразмеряване";
			viewPort.Invalidate();
		}

        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.SelectAll();
			statusBar.Items[0].Text = "Последно действие: Избиране на всички примитиви.";
			viewPort.Invalidate();
		}

        private void UnselectAllBtn_Click(object sender, EventArgs e)
        {
			dialogProcessor.UnselectAll();
			statusBar.Items[0].Text = "Последно действие: Избиране на всички примитиви.";
			viewPort.Invalidate();
		}

        private void Rotate180Btn_Click(object sender, EventArgs e)
        {
			dialogProcessor.Rotate180();
			viewPort.Invalidate();
			statusBar.Items[0].Text = "Последно действие: Завъртане на примитив 180 градуса";
		}

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Copy();
			statusBar.Items[0].Text = "Последно действие: Копиране на селектираните примитиви";
			viewPort.Invalidate();
		}

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Paste();
			statusBar.Items[0].Text = "Последно действие: Поставяне на селектираните примитиви";
			viewPort.Invalidate();
		}

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{

				dialogProcessor.SerializeIt(dialogProcessor.ShapeList, saveDialog.FileName);
			}
		}

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (loadDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				dialogProcessor.ShapeList = (List<Shape>)dialogProcessor.DeserializeIt(loadDialog.FileName);
				viewPort.Invalidate();
			}
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
		
				dialogProcessor.AddRandomExam();

				statusBar.Items[0].Text = "Последно действие: Рисуване на izpitna zadacha";

				viewPort.Invalidate();
			
		}
    }
}
