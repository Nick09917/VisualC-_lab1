Практическая работа № 1 По Дисциплине Визуальное программирование
=====================
### Разместите на форме ряд кнопок (Button), и одно поле ввода (TextBox). Создайте обработчики события нажатия на данные кнопки, которые будут менять текст на нажатой кнопке. Текст на кнопке берется из поля ввода
```C#
 public partial class Form1 : Form
 {
     public Form1()
     {
         InitializeComponent();
     }


     private void Form1_Load(object sender, EventArgs e)
     {
         BackColor = Color.AntiqueWhite;
     }

     private void button1_Click(object sender, EventArgs e)
     {
         if (string.IsNullOrWhiteSpace(textBox2.Text))
         {
             Console.WriteLine("pass");
             MessageBox.Show("Ничего не введено", "Попался!");
         }
         else
             button1.Text = textBox2.Text;
     }

     private void label1_Click(object sender, EventArgs e)
     {

     }

     private void button2_Click(object sender, EventArgs e)
     {
         if (string.IsNullOrWhiteSpace(textBox2.Text))
         {
             Console.WriteLine("pass");
             MessageBox.Show("Ничего не введено", "Попался!");
         }
         else
             button2.Text = textBox2.Text;
     }

     private void button3_Click(object sender, EventArgs e)
     {
         if (string.IsNullOrWhiteSpace(textBox2.Text))
         {
             Console.WriteLine("pass");
             MessageBox.Show("Ничего не введено", "Попался!");
         }
         else
         {

             button3.Text = textBox2.Text;
         }
     }

     private void button4_Click(object sender, EventArgs e)
     {
         if (string.IsNullOrWhiteSpace(textBox2.Text))
         {
             Console.WriteLine("pass");
             MessageBox.Show("Ничего не введено","Попался!");
         }
         else
             button4.Text = textBox2.Text;
     }
 }
```

![1](https://github.com/Nick09917/VisualC-_lab1/assets/115313324/5f069e5d-66f4-4163-a925-3dc4cad41a1a)

![2](https://github.com/Nick09917/VisualC-_lab1/assets/115313324/1d7afd1b-9d32-4b64-b358-e85d4013759d)



