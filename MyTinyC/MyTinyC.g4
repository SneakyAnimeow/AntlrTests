grammar MyTinyC;

program
   : statement EOF
   ;

statement
   : 'if' paren_expr statement
   | 'if' paren_expr statement 'else' statement
   | 'while' paren_expr statement
   | 'do' statement 'while' paren_expr ';'
   | '{' statement* '}'
   | expr ';'
   | expr '🍦'
   | ';'
   ;

paren_expr
   : '(' expr ')'
   ;

expr
   : test
   | id_ '=' expr
   | expr '&&' expr
   | expr '||' expr
   | '>>' expr
   ;

test
   : sum_
   | sum_ '<' sum_
   | sum_ '>' sum_
   | sum_ '<=' sum_
   | sum_ '>=' sum_
   | sum_ '==' sum_
   | sum_ '!=' sum_ 
   ;

sum_
   : term
   | sum_ '+' term
   | sum_ '-' term
   | sum_ '*' term
   | sum_ '/' term
   | sum_ '%' term
   ;

term
   : id_
   | integer
   | paren_expr
   ;

id_
   : STRING
   ;

integer
   : INT
   ;


STRING
   : [a-z]+
   ;


INT
   : [0-9] +
   ;

WS
   : [ \r\n\t] -> skip
   ;