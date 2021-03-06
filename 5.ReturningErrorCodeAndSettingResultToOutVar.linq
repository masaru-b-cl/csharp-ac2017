<Query Kind="Program" />

string ReturningErrorCodeAndSettingResultToOutVar(string name, out string greeting)
{
  if (string.IsNullOrEmpty(name))
  {
    greeting = null;
    return "E001";
  }	

  // some validation with return error code "Exxx";

  greeting = $"Hello! {name}";

  return string.Empty;
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var errorCode = ReturningErrorCodeAndSettingResultToOutVar(userName, out var result);
  switch(errorCode)
  {
    case "E001" :
      Console.WriteLine("name is empty!");
      return;
  	
    // case "Exx" :
    //   error handling
    //   return;
  }
  
  Console.WriteLine(result);
}