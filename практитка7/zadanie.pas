program prakt7;
const n=10;
type ms =Array [1..n] of integer;
var
  a:ms;
  i,sum,k:integer;
  begin
    sum:=0;
    pos:=0;
    neg:=0;
    writeln('Введите число');
    readln(k);
    writeln('Введите элементы массива');
    for i:=1 to n do
      begin
      readln(a[i]);
      if a[i] mod k=0 then sum:=sum+a[i];
      end;
    writeln('сумма элементов массива', sum);
  end.