using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFE
{
    public class functions
    {
        private static DialogResult confirmationBoxTemplate(string msg)
        {
            string title = "Alerte";

            MessageBoxButtons options = MessageBoxButtons.YesNo;

            return MessageBox.Show(msg, title, options);
        }

        private static DialogResult errorMsgBoxTemplate(string msg)
        {
            string title = "Erreur";

            MessageBoxButtons options = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            return MessageBox.Show(msg, title, options, icon);
        }

        private static DialogResult remarkMsgBoxTemplate(string msg)
        {
            string title = "Remarque";

            MessageBoxButtons options = MessageBoxButtons.OK;

            return MessageBox.Show(msg, title, options);
        }

        public static DialogResult confirmationBox()
        {
            string msg = "Etes-vous sûr que vous voulez supprimer";
            return confirmationBoxTemplate(msg);
        }

        public static void tableVide()
        {
            string msg = "La Table est Vide";
            remarkMsgBoxTemplate(msg);
        }

        public static void errorMsgBox()
        {
            string msg = "Rencontré une Erreur";
            errorMsgBoxTemplate(msg);
        }

        public static void invalidLogin()
        {
            string msg = "Nom d'Utilisateur ou Mot de Passe Invalide";
            errorMsgBoxTemplate(msg);
        }

        public static void cantBeEmpty()
        {
            string msg = "Nom d'Utilisateur ou le Mot de Passe Ne Peut Pas Être Vide";
            errorMsgBoxTemplate(msg);
        }
    }
}
