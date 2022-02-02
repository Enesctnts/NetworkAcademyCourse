using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_10_WindowsForms_OOP
{ 
    class Araba
    {
        public int ID;
        public string Marka;
        public string Model;
    /*YAPICI METOTLAR: CONSTRUCTOR
 * Metot adı sınıf adı ile aynı olmalıdır. Public olmalıdır.
 * Tanımlanmasa da boş hali arka planda çalışır.
 */
    public Araba()
        {
            MessageBox.Show("Yapıcı metot çalıştı");
        }
    public Araba(int ID, string marka, string model)
    {

        MessageBox.Show("3 parametreli yapıcı metot çalıştı");
        this.ID = ID;
        Marka = marka;
        Model = model;
    }

    public void BilgiYaz()
        {
            MessageBox.Show("ID:" + ID);
            MessageBox.Show("Marka:" + Marka);
            MessageBox.Show("Model:" + Model);
        }

    }
}
