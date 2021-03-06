<Query Kind="Program" />

// メソッド定義
bool ReturningIsValidAndSettingResultToOutVar(string name, out string greeting)
{
  if (string.IsNullOrEmpty(name))
  {
    greeting = null;
    return false;
  }

  greeting = $"Hello! {name}";
  
  return true;
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var isValid = ReturningIsValidAndSettingResultToOutVar(userName, out var result);
  if (!isValid)
  {
    Console.WriteLine("Some Error!");
    return;
  }
  
  Console.WriteLine(result);	
}