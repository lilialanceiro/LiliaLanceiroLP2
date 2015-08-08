using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho11_2C
{
    public partial class Form1 : Form
    {

        int qntdcarros;
        int qntdpassageiros;
        List<Carro> carros = new List<Carro>();
        int i = 0;
        int passageirosregistrados = 0;
        int carrosadicionados = 0;
        int vagasrestantes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qntdcarros = int.Parse(qtdcarros.Text);
            qntdpassageiros = int.Parse(qtdpassageiros.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (carrosadicionados < qntdcarros)
            {
                Carro carrinho = new Carro();

                carrinho.Id = i + 1;
                carrinho.Modelo = ModeloBox.Text;
                carrinho.Marca = MarcaBox.Text;
                carrinho.Placa = PlacaBox.Text;
                carrinho.Vagas = int.Parse(VagasBox.Text);

                carros.Add(carrinho);
            }

                  if (i >= qntdcarros)
                   {
                       MessageBox.Show("Todos os carros já foram adicionados");
                   }


                  carrosadicionados += 1;
                  i += 1;
        }


        int idboxatt;

        private void button3_Click(object sender, EventArgs e)
        {
            idboxatt = int.Parse(IdBox.Text) - 1;

            if (passageirosregistrados < qntdpassageiros)
            {
                if (idboxatt < 0 || idboxatt > qntdcarros - 1)
                {
                    MessageBox.Show("Carro inválido");
                }

                else
                {
                    if (carros[idboxatt].Passageiros < carros[idboxatt].Vagas)
                    {
                        carros[idboxatt].Passageiros += 1;
                        passageirosregistrados += 1;
                    }

                    else
                    {
                        MessageBox.Show("Vagas do carro " + IdBox.Text + " esgotadas!");
                    }
                }
            }

            else
            {
                MessageBox.Show("Todos os passageiros já foram alocados com SUCESSO!");

                for (int k = 0; k < qntdcarros; k++)
                {
                    vagasrestantes = carros[k].Vagas - carros[k].Passageiros;

                    MessageBox.Show("Carro " + carros[k].Id + ": " +carros[k].Modelo+ " - " +carros[k].Marca+ " (" +carros[k].Placa+ ") \nPassageiros: " +carros[k].Passageiros+ "\nVagas restantes: " +vagasrestantes+"");
                }
            }
        }
    }
}
