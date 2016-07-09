/*
 * Created by SharpDevelop.
 * User: IstvanT
 * Date: 7/9/2016
 * Time: 12:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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

namespace MusicPlayer
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
		void Button1_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("boop");
		}
	}
}