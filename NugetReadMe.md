# MKit.VectorIcons

## Usage

Add MKit.VectorIcons Assembly Reference to `xaml` file.

```xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
  x:Class="VectorIconsAppSample.MainPage"
  xmlns="http://xamarin.com/schemas/2014/forms"
  xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
  xmlns:antDesign="clr-namespace:MKit.VectorIcons.AntDesign;assembly=MKit.VectorIcons"
  xmlns:fontAwesome="clr-namespace:MKit.VectorIcons.FontAwesome;assembly=MKit.VectorIcons"
  xmlns:materialIcons="clr-namespace:MKit.VectorIcons.MaterialIcons;assembly=MKit.VectorIcons">
```

And use it:

### Icon Font
Example for `AntDesign` and `FontAwesome`:

```xaml
    <antDesign:Icon
      Name="Addusergroup"
      FontSize="40"
      HorizontalOptions="Center"
      VerticalOptions="Center" />

    <fontAwesome:Icon 
       Name="Automobile" />
```

### Icon Button

Example for `MaterialIcon` IconButton:

```xaml
    <materialIcons:IconButton
      Name="Agriculture"
      Padding="8"
      BackgroundColor="LightSeaGreen"
      HorizontalOptions="Center"
      IconColor="White"
      Text="My car"
      TextColor="White" />
```

### Icon Image Source
```xaml
  <Image>
      <Image.Source>
          <antDesign:IconFontImageSource Name="Amazon" />
      </Image.Source>
  </Image>

  <Image>
      <Image.Source>
          <materialIcons:IconFontImageSource Name="Airplay" />
      </Image.Source>
  </Image>
  
  <Image>
      <Image.Source>
          <fontAwesome:IconFontImageSource Name="Bandcamp" />
      </Image.Source>
  </Image>
```

## More Details Visit:
https://github.com/ThinhTranA/MKit.VectorIcons




## What works

All icons for these fonts:

- [x] AntDesign
- [x] Entypo
- [x] EvilIcons
- [x] Feather
- [x] FontAwesome
- [x] FontAwesome5 Free Regular & Solid
- [x] Fontisto
- [x] Foundation
- [x] Ionicons
- [x] MaterialIcons ( except `Goat` icon, see reason below)
- [x] Octicons
- [x] SimpleLineIcons
- [x] Zocial

## What doesn't work

Any font codes that has unicode value greater than 2 bytes

(x)  MaterialCommunityIcons  (99% of the icons have font codes value greater than 2 bytes)

(x)  FontAwesome5 Brand. (WIP) due to Glyph json file for FontAwesome5 combine all 3 regular solid & brand, this is fixable by create a seperate Glyph json file for FontAwesome 5 brand. 
