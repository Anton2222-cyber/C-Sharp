using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgressBarMyTest
{
    public partial class Test : Form
    {
        int i = 1;
        int mark = 0;
        public Test()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            switch(i)
            {
                case 1:
                    Question.Text = "2.Динамічний сайт – сайт, вміст якого може:";
                    a.Text = "змінюватися.";
                    b.Text = "залишатися без змін.";
                    c.Text = "залишатися без змін або змінюватися з певним періодом.";
                    d.Text = "немає правильної відповіді";
                    if (a.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 2:
                    Question.Text = "3.Вкажіть програму, яка за запитом визначає до якого саме сайту він відноситься і обробляє запит залежно від способу побудови сайту і властивостей самого запиту.";
                    a.Text = "веб-сервер";
                    b.Text = "веб-сайт";
                    c.Text = "веб-клієнт";
                    d.Text = "немає правильної відповіді";
                    if (a.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 3:
                    Question.Text = "4.Перевірка синтаксичних помилок, вкладеності тегів та інші критерії - це ...";
                    a.Text = "валідація сайта";
                    b.Text = "веб-браузер";
                    c.Text = "автентифікація";
                    d.Text = "кросбраузерність";
                    if (a.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 4:
                    Question.Text = "5.Взаємодія між клієнтом і сервером починається з:";
                    a.Text = "ініціативи користувача";
                    b.Text = "ініціативи клієнта";
                    c.Text = "ініціативи сервера";
                    d.Text = "немає правильної відповіді";
                    if (a.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 5:
                    Question.Text = "6.Для створення HTML форми на сторінці використовується тег";
                    a.Text = "<title>";
                    b.Text = "<form>";
                    c.Text = "<head>";
                    d.Text = "<body>";
                    if (b.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 6:
                    Question.Text = "7.Для введення текстових даних у спеціальні поля використовують тег ...";
                    a.Text = "INPUT";
                    b.Text = "FORM";
                    c.Text = "TYPE";
                    d.Text = "VALUE";
                    progressBar.PerformStep();
                    if (b.Checked == true)
                        mark++;
                    break;
                case 7:
                    Question.Text = "8.Максимальна кількість символів для введення регламентується за допомогою атрибуту тегу INPUT";
                    a.Text = "VALUE";
                    b.Text = "SIZE";
                    c.Text = "MAXLENGTH";
                    d.Text = "NAME";
                    if (b.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 8:
                    Question.Text = "9.Між тегами <SELECT> ... </SELECT> вказують";
                    a.Text = "текстову інформацію, яку можна обрати";
                    b.Text = "інформацію, що вводиться вручну";
                    c.Text = "список атрибутів";
                    d.Text = "елементи списку запропонованих варіантів у формі";
                    if (c.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 9:
                    Question.Text = "9.Між тегами <SELECT> ... </SELECT> вказують";
                    a.Text = "текстову інформацію, яку можна обрати";
                    b.Text = "інформацію, що вводиться вручну";
                    c.Text = "список атрибутів";
                    d.Text = "елементи списку запропонованих варіантів у формі";
                    if (d.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 10:
                    Question.Text = "11.HTML -  це";
                    a.Text = "посилання на набір правил doctypes, яким має слідувати HTML-сторінка, також вказівка на автоматичну перевірку помилок і інші корисні речі. ";
                    b.Text = "мова розмітки, яка використовується для розміщення елементів (тексту, картинок, кнопок, таблиць тощо) на сторінці, тобто, для складання структури.";
                    c.Text = "елемент містить весь контент, який бачать відвідувачі - текст, зображення, відео, анімація тощо.";
                    d.Text = "немає правильної відповіді";
                    if (b.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 11:
                    Question.Text = "12.Початковий тег";
                    a.Text = "складається з назви елемента (<p>), з цього моменту тег починає впливати на той вміст, що слідує за ним.";
                    b.Text = "складається з назви елемента (<!-- текст коментаря -->).";
                    c.Text = "починається з назви сайту.";
                    d.Text = "немає правильної відповіді";
                    if (b.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    break;
                case 12:
                    
                    if (a.Checked == true)
                        mark++;
                    progressBar.PerformStep();
                    Thread.Sleep(500);
                    MessageBox.Show("Ви набрали: " + mark + " балів з 12");
                    break;
               
            }
            i++;
            
        }
    }
}
