program Kamaltdinov_Andrey_PR23;
const n=6;
type ms =Array [1..n] of integer;
var
  a:ms;
  i:integer;
  begin
    writeln('Введите элементы массива');
    for i:=1 to n do
      readln(a[i]);
    for i:=n downto 1 do
      write(a[i],' ');
  end.