<Query Kind="Program" />

// 独自定義の例外
class MyException : Exception
{
  public string ErrorCode {get; set;}
}

// メソッド定義
(string result, Exception exception) ReturningResultAndExceptionAsValueTuple(string name)
{
  if (string.IsNullOrEmpty(name))
  {
    return (null, new ArgumentNullException(nameof(name)));
  }

  string person = FindByName(name);
  if (person == null)
  {
    return (null, new MyException { ErrorCode = "E001" });
  }

  return ($"Hello! {name}", null);
}

string FindByName(string name)
{
  // 名前から人を探しに行く
  if (name.StartsWith("0"))
  {
    // 見つからなかった
    return null;
  }

  return "FullName";
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var (result, exception) = ReturningResultAndExceptionAsValueTuple(userName);
  switch(exception)
  {
    case ArgumentNullException ex :
      Console.WriteLine($"{ex.ParamName} is empty!");
      return;

    case MyException ex :
      Console.WriteLine($"Some Error: {ex.ErrorCode}");
      return;

    case Exception ex:
		  throw ex;
  }
  Console.WriteLine(result);
}