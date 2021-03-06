<Query Kind="Program" />

// メソッド定義
string ReturningResultOrErrorCode(string name)
{
  if (string.IsNullOrEmpty(name)) return "E001";
	
  // some validation with return error code "Exxx";
	
  return $"Hello! {name}";
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var result = ReturningResultOrErrorCode(userName);
  switch(result)
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