# ShopApp

Simple windows forms interface and local save files

## Uses

.NET Framework 6.0
[Newtonsoft](https://www.newtonsoft.com/json)

## Facilites

Sign Up/Login user (Json format).
Searching for a product (React-hook kinda).
Adding the product to cart (multiple clicks on the product will increase the ammount added to the cart).
Order placing (Json format).

## Saved data
```c#
var RootPath = ConfigurationManager.AppSettings["Products"];
string FileName = "PLACEHOLDER.json";
if (string.IsNullOrEmpty(RootPath))
{
  RootPath = "PLACEHOLDER";
}
if (!Directory.Exists(RootPath)) Directory.CreateDirectory(RootPath);
if (!File.Exists(Path.Combine(RootPath, FileName))) File.Create(Path.Combine(RootPath, FileName)).Close();
Root = Path.Combine(RootPath, FileName);
```


