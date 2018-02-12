This sample code is going to show how to use a common control to show a user interface on the screen

Solution is built using Xamarin Forms

A seperate Content View is created as LoginView as below.

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

