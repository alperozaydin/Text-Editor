using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing.Text;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for TextEditorToolbar.xaml
    /// </summary>
    public partial class TextEditorToolbar : UserControl
    {
        public TextEditorToolbar()
        {
            Loaded += UserControl_Loaded;
            InitializeComponent();

        }

        public bool IsSynchronizing { get; private set; }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            for (double i = 8; i < 48; i += 2)
            {
                fontSize.Items.Add(i);
            }
            var myFontList = new InstalledFontCollection().Families;

            foreach (var f in myFontList)
            {
                fontList.Items.Add(f.Name);
            }
        }

        public void SynchronizeWith(TextSelection selection)
        {
            IsSynchronizing = true;

            Synchronize<FontStyle>(selection, TextBlock.FontStyleProperty, SetFontStyle);
            Synchronize<double>(selection, TextBlock.FontSizeProperty, SetFontSize);
            Synchronize<FontFamily>(selection, TextBlock.FontFamilyProperty, SetFontFamily);
            Synchronize<FontWeight>(selection, TextBlock.FontWeightProperty, SetFontWeight);
            Synchronize<TextDecorationCollection>(selection, TextBlock.TextDecorationsProperty, SetTextDecoration);
            IsSynchronizing = false;
        }

        private void Synchronize<T>(TextSelection selection, DependencyProperty property, Action<T> methodToCall)
        {
            object value = selection.GetPropertyValue(property);
            if (value != DependencyProperty.UnsetValue) methodToCall((T) value);
        }

        private void SetFontSize(double size)
        {
            fontSize.SelectedValue = size;
        }

        private void SetFontFamily(FontFamily family)
        {
            fontList.SelectedItem = family.ToString();
        }

        private void SetFontStyle(FontStyle style)
        {
            ItalicButton.IsChecked = style == FontStyles.Italic;
        }

        private void SetFontWeight(FontWeight weight)
        {
            BoldButton.IsChecked = weight == FontWeights.Bold;
        }

        private void SetTextDecoration(TextDecorationCollection decoration)
        {
           UnderlineButton.IsChecked = decoration == TextDecorations.Underline;
        }
    }
}
