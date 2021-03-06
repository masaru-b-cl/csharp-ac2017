<Query Kind="Program" />

// エラーの種類
enum ErrorType
{
  NoError,
  NameIsEmpty,
  // SomeError
}

// メソッド定義
ErrorType ReturningErrorTypeAndSettingResultToOutVar(string name, out string greeting)
{
  if (string.IsNullOrEmpty(name))
  {
    greeting = null;
    return ErrorType.NameIsEmpty;
  }	

  // some validation with return error code "Exxx";

  greeting = $"Hello! {name}";

  return ErrorType.NoError;
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var errorType = ReturningErrorTypeAndSettingResultToOutVar(userName, out var result);
  switch(errorType)
  {
    case ErrorType.NoError :
      Console.WriteLine(result);
      return;
  
    case ErrorType.NameIsEmpty :
      Console.WriteLine("name is empty!");
      return;
  	
    // case ErrorType.SomeError :
    //   error handling
    //   return;
  }
}
