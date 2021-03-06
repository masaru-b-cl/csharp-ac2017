<Query Kind="Program" />

// メソッド定義
string ReturningResultOnly(string name)
{
  if (string.IsNullOrEmpty(name)) return null;
	
  return $"Hello! {name}";
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var result = ReturningResultOnly(userName);
  if (result == null)
  {
    Console.WriteLine("Some Error!");
    return;
  }
  
  Console.WriteLine(result);
}