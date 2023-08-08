grammar NekoScript;

program: statement* EOF;

statement: assign_statement;

assign_statement: expression '=' expression;

expression
    : ID
    | NUMERIC
    | STRING
    | BOOL
    | expression '+' expression // Add or concat expression
    | expression '-' expression // Substract expression
    | expression '*' expression // Multiply expression
    | expression '/' expression // Divide expression
    | expression '%' expression // Modulo expression
    | expression '^' expression // Power expression
    | expression '==' expression // Equal expression
    | expression '!=' expression // Not equal expression
    | expression '<' expression // Less than expression
    | expression '<=' expression // Less than or equal expression
    | expression '>' expression // Greater than expression
    | expression '>=' expression // Greater than or equal expression
    | expression '&&' expression // And expression
    | expression '||' expression // Or expression
    | expression '?' expression ':' expression // Ternary expression
    | '(' expression ')' // Parenthesis expression
    | expression '[' expression ']' // Array access expression
    | expression '.' ID '(' expression_list ')' // Function call expression
    ;

expression_list: expression (',' expression)*;

VAR: 'var';

NUMERIC : INT | FLOAT;

INT : [0-9]+;
FLOAT : [0-9]*'.'[0-9]+;
ID : [a-zA-Z_][a-zA-Z0-9_]*;
STRING : '"' .*? '"';
BOOL : 'true' | 'false';

WS: [ \t\u000C\r\n]+ -> skip;
COMMENT:            '/*' .*? '*/'    -> channel(HIDDEN);
LINE_COMMENT:       '//' ~[\r\n]*    -> channel(HIDDEN);