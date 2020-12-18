using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalorieKalkulator
{
    public partial class initialize : Form
    {
        int age;
        string sex;
        int height;
        float weight;
        int activityLevel;
        float caloricDemand;

        public initialize()
        {
            InitializeComponent();
        }

        void inputDdata(object sender, EventArgs e)
        {
            try
            {
                age = Int32.Parse(tWiek.Text);
            }catch(ArgumentException ex)
            {
                showError();
            }

            if (sexm.Checked)
            {
                sex = "m";
            }

            else
            {
                sex = "k";
            }

            try
            {
                height = Int32.Parse(tWzrost.Text);
            }catch(ArgumentException ex)
            {
                showError();
            }

            try
            {
                weight = float.Parse(tWaga.Text);
                weight = (float)Math.Round(weight, 1, MidpointRounding.ToEven);
            }
            catch (ArgumentException ex)
            {
                showError();
            }

            activityLevel = Int32.Parse(nAktywnosc.Text);

            if (checkInputData(age,sex,height,weight,activityLevel) == true)
            {
                caloricDemand = calculateDailyCaloricDemand(age, sex, height, weight, activityLevel);
                showResult(caloricDemand);
            }

        }

        Boolean checkInputData(int age, string sex, int height, float weight, int activityLevel)
        {
            if (age > 0 && age <= 150)
            {
                if (height>0 && height < 300)
                {
                    if (weight>0 && weight < 600)
                    {
                        return true;
                    }
                    else
                    {
                        showError();
                        return false;
                    }
                }
                else
                {
                    showError();
                    return false;
                }
            }
            else
            {
                showError();
                return false;
            }
        }

        float calculateDailyCaloricDemand(int age, string sex, int height, float weight, int activityLevel)
        {
            if (sex == "m")
            {
                if (activityLevel == 1)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) + 5) * 1.2);
                }
                else if (activityLevel == 2)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) + 5) * 1.3);
                }
                else if (activityLevel == 3)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) + 5) * 1.5);
                }
                else if (activityLevel == 4)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) + 5) * 1.7);
                }
                else
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) + 5) * 1.9);
                }
            }
            else
            {
                if (activityLevel == 1)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) - 161) * 1.2);
                }
                else if (activityLevel == 2)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) - 161) * 1.3);
                }
                else if (activityLevel == 3)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) - 161) * 1.5);
                }
                else if (activityLevel == 4)
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) - 161) * 1.7);
                }
                else
                {
                    return (float)(((weight * 9.99) + (6.25 * height) - (4.92 * age) - 161) * 1.9);
                }
            }
        }

        void showResult(float caloricDemand)
        {
            lWynik.Text = Convert.ToString(caloricDemand);
        }

        void showError()
        {
            lWynik.Text = "Proszę podać realne dane";
        }
    }
}
