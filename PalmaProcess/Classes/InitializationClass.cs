using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M2.Classes
{
    public class InitializationClass
    {
        private ProcessModeling.Form1 Form = new ProcessModeling.Form1();
        public void InitTransitionMatrix(double[,] MatrixofSwitchings)
        {
            
            MatrixofSwitchings[0, 0] = Convert.ToDouble(Form.textBoxP11.Text);
            MatrixofSwitchings[0, 1] = Convert.ToDouble(Form.textBoxP12.Text);
            MatrixofSwitchings[0, 2] = Convert.ToDouble(Form.textBoxP13.Text);

            MatrixofSwitchings[1, 0] = Convert.ToDouble(Form.textBoxP21.Text);
            MatrixofSwitchings[1, 1] = Convert.ToDouble(Form.textBoxP22.Text);
            MatrixofSwitchings[1, 2] = Convert.ToDouble(Form.textBoxP23.Text);

            MatrixofSwitchings[2, 0] = Convert.ToDouble(Form.textBoxP31.Text);
            MatrixofSwitchings[2, 1] = Convert.ToDouble(Form.textBoxP32.Text);
            MatrixofSwitchings[2, 2] = Convert.ToDouble(Form.textBoxP33.Text);
        }

        public void InitializeStartDistribution(double[] StartDistribution)
        {
            StartDistribution[0] = Convert.ToDouble(Form.textBoxP11.Text);
            StartDistribution[1] = Convert.ToDouble(Form.textBoxP12.Text);
            StartDistribution[2] = Convert.ToDouble(Form.textBoxP13.Text);
        }

        public void InitializeComboBoxRozpodil(System.Windows.Forms.ComboBox comboBoxRozpodilMinus)
        {
            Form.comboBoxRozpodilMinus.Items.Add("Рівномірний");
            Form.comboBoxRozpodilMinus.Items.Add("Експоненційний");
            Form.comboBoxRozpodilMinus.Items.Add("розподіл Вейбула");
            Form.comboBoxRozpodilMinus.Items.Add("Нормальний розподіл");
            Form.comboBoxRozpodilMinus.Items.Add("Логарифмічно нормальний");
            Form.comboBoxRozpodilMinus.Items.Add("Ерланга");
            Form.comboBoxRozpodilMinus.Items.Add("хі-квадрат");
            Form.comboBoxRozpodilMinus.Items.Add("розподіл Релея");
            Form.comboBoxRozpodilMinus.Items.Add("Стьюдента");
            Form.comboBoxRozpodilMinus.Items.Add("Фішера");
            Form.comboBoxRozpodilMinus.Items.Add("Бета-розподіл");
            Form.comboBoxRozpodilMinus.SelectedIndex = 1;
        }

        public void InitializeProcessParameter()
        {
            Form.comboBox1.Items.Add("к-сть переходів");
            Form.comboBox1.Items.Add("тривалість");
            Form.comboBox1.SelectedIndex = 0;
        }


    }
}
