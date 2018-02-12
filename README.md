This sample code is going to show how to use a common control to show a user interface on the screen

Solution is built using Xamarin Forms, 

A seperate Content View is created as LoginView as below.

```html
<ContentView xmlns="http://xamarin.com/schemas/2014/forms" 
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="UserControl.LoginView" x:Name="this">
  <ContentView.Content>
  
        <StackLayout Padding="20">
            <Label Text="{Binding Text, Source={x:Reference this}}" FontAttributes="Bold" FontSize="20" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
            <Button x:Name="buttonItem" Text="{Binding ButtonText, Source={x:Reference this}}"  HorizontalOptions="Center"/>
        </StackLayout>
  
    </ContentView.Content>
</ContentView>
```
In the code behind file of the user control, define the binding property as below,

    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(LoginView));
    
     public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }
        
 If you want to change styles and configurations specific to device, use this code block
 
    switch (Device.RuntimePlatform)
     {
          case Device.iOS:
              this.Padding = new Thickness(20, 40, 20, 20);
              break;
          default:
              this.Padding = new Thickness(20);
              break;
      }

In main page, call the user control and pass parameters as below,

```html
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:UserControl"
             x:Class="UserControl.MainPage"
             xmlns:control="clr-namespace:UserControl">
	
    <StackLayout>
        <control:LoginView Text="Product Application" ButtonText="Click ME!!!!!"/>
    </StackLayout>

</ContentPage>
```
