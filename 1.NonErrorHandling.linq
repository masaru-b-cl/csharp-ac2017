<Query Kind="Program" />

// メソッド定義
string NonErrorHandling(string name){
  return $"Hello! {name}";
}

void Main()
{
  // 呼び出し
  var userName = "Sho";
  var result = NonErrorHandling(userName);	
}