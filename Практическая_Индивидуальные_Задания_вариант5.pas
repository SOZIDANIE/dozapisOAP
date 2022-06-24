Program prakt1_indiv_variant5;
const k := 1.5;
var
    S:integer;
    A,B,t:real;
begin
  writeln('Введите расстояние от станции до озера');
  readln(S);
    writeln('Введите скорость с которой двигались туристы пешком');
  readln(A);
    writeln('Введите скорость с которой ехала попутная машина');
  readln(B);
  if B>0 :
    t := S-(k * A)/B;
    writeln
end.