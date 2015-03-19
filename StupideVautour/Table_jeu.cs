﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupideVautour
{
    public partial class Table_jeu : Form
    {

        int[,] mains_joueurs;
        int[] pioche_point;
        int Jeu_etat;


        public Table_jeu(int nbJoueurs)
        {
            int i;
            int j;
            InitializeComponent();
            mains_joueurs = new int[nbJoueurs,15];
            for(i = 0; i < nbJoueurs-1; i++)
            {
                for(j=0;j<15;j++)
                {
                    mains_joueurs[i,j] = 1;
                }
            }
            pioche_point = new int[15];
            melangedeck(pioche_point, 15);
            Jeu_etat = 0;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        void melangedeck(int[] tabl, int taille)
        {
            int i;
            int j;
            Random alea;
            int[] trie = { -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (i = 0; i < 15; i++)
            {
                do
                {
                    alea = new Random();
                    j = alea.Next(15);
                } while (trie[j] == 0);
                tabl[i] = trie[j];
                trie[j] = 0;
            }
        }


    }
}