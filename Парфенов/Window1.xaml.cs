/*
 * Создано в SharpDevelop.
 * Пользователь: студент
 * Дата: 26.09.2018
 * Время: 8:01
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Парфенов
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		double a;
		double b;
		double c;
		void multiplication_Click(object sender, RoutedEventArgs e)
		{
			//throw new NotImplementedException();
			a = Convert.ToDouble(chislo1.Text);
		b = Convert.ToDouble(chislo2.Text);
			c = a*b;
			resultbox.Text = c.ToString();
			                        
		}
		void division_Click(object sender, RoutedEventArgs e)
		{
			//throw new NotImplementedException();
				a = Convert.ToDouble(chislo1.Text);
		b = Convert.ToDouble(chislo2.Text);
			c = a/b;
			resultbox.Text = c.ToString();
			
		}
		void minus_Click(object sender, RoutedEventArgs e)
		{
			//throw new NotImplementedException();
				a = Convert.ToDouble(chislo1.Text);
		b = Convert.ToDouble(chislo2.Text);
		c = a-b;
		resultbox.Text = c.ToString();
		}
		void addition_Click(object sender, RoutedEventArgs e)
		{
			//throw new NotImplementedException();
			a = Convert.ToDouble(chislo1.Text);
		b = Convert.ToDouble(chislo2.Text);
		c = a+b;
		resultbox.Text = c.ToString();
		}
		
	
		}
	}
