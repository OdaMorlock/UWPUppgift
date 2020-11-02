using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPUppgift
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        

        public MainPage()
        {
            this.InitializeComponent();
        }
        private async void TextFile_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();

            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;

            openPicker.FileTypeFilter.Add(".txt");
            try
            {
                StorageFile file = await openPicker.PickSingleFileAsync();
                try
                {
                    string text = await Windows.Storage.FileIO.ReadTextAsync(file);
                    try
                    {
                        FileContent.Text = text;
                    }
                    catch (Exception)
                    {

                        OutputTextBlock.Text = "Operation Faild too write the content into TextFile.";
                    }
                }
                catch (Exception)
                {

                    OutputTextBlock.Text = "Operation Failed too convert content in file to text .";
                }
            }
            catch (Exception)
            {

                OutputTextBlock.Text = "Operation Failed too open file.";
            }

        }

        private async void JsonFile_Click(object sender, RoutedEventArgs e)
        {

            FileOpenPicker openPicker = new FileOpenPicker();

            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;

            openPicker.FileTypeFilter.Add(".json");
            try
            {
                StorageFile file = await openPicker.PickSingleFileAsync();
                try
                {
                    string text = await Windows.Storage.FileIO.ReadTextAsync(file);
                    try
                    {
                        FileContent.Text = text;
                    }
                    catch (Exception)
                    {

                        OutputTextBlock.Text = "Operation Faild too write the content into TextFile.";
                    }
                }
                catch (Exception)
                {

                    OutputTextBlock.Text = "Operation Failed too convert content in file to text .";
                }
            }
            catch (Exception)
            {

                OutputTextBlock.Text = "Operation Failed too open file.";
            }
                  
        }

        private async void XmlFile_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();

            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;

            openPicker.FileTypeFilter.Add(".xml");
            try
            {
                StorageFile file = await openPicker.PickSingleFileAsync();
                try
                {
                    string text = await Windows.Storage.FileIO.ReadTextAsync(file);
                    try
                    {
                        FileContent.Text = text;
                    }
                    catch (Exception)
                    {

                        OutputTextBlock.Text = "Operation Faild too write the content into TextFile.";
                    }
                }
                catch (Exception)
                {

                    OutputTextBlock.Text = "Operation Failed too convert content in file to text .";
                }
            }
            catch (Exception)
            {

                OutputTextBlock.Text = "Operation Failed too open file.";
            }

        }

        private async void CsvFile_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();

            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;

            openPicker.FileTypeFilter.Add(".csv");
            try
            {
                StorageFile file = await openPicker.PickSingleFileAsync();
                try
                {
                    string text = await Windows.Storage.FileIO.ReadTextAsync(file);
                    try
                    {
                        FileContent.Text = text;
                    }
                    catch (Exception)
                    {

                        OutputTextBlock.Text = "Operation Faild too write the content into TextFile.";
                    }
                }
                catch (Exception)
                {

                    OutputTextBlock.Text = "Operation Failed too convert content in file to text .";
                }
            }
            catch (Exception)
            {

                OutputTextBlock.Text = "Operation Failed too open file.";
            }

        }

    }
}
