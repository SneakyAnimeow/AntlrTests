grammar NekoScript;

program: (imports | directive)*? code_block* EOF;

imports: 'import' path 'as' id (';')*?;

code_block: class | function | block | expr | directive;

class: 'class' id ('implements' id ('.' id)*? (',' id ('.' id)*? )*? )? '{' class_member* '}' (';')*? ;

class_member: function | variable;

variable: id ('=' expr)? (';')*?;

function: 'function' id '(' (id (',' id )*)? ')' '{' code_block* '}';

block: if | while | for | for_each | return | break | continue | expr | switch;

if: 'if' '(' expr ')' '{' code_block* '}' ('else' '{' code_block* '}')?;

while: 'while' '(' expr ')' '{' code_block* '}';

for: 'for' '(' expr? ';' expr? ';' expr? ')' '{' code_block* '}';

return: 'return' expr? (';')*?;

break: 'break' (';')*?;

continue: 'continue' (';')*?;

for_each: 'for' '(' id ':' expr ')' '{' code_block* '}';

switch: 'switch' '(' expr ')' '{' switch_case* '}' (';')*?;

switch_case: 'case' expr '->' '{' code_block* '}' ('break' (';')*?)?
    | 'default' '->' '{' code_block* '}' ('break' (';')*?)?;

directive: '#' id ;

expr: expr ('+' | '-' | '*' | '/' | '^' ) expr (';')*?
    | expr ('<' | '>' | '<=' | '>=' | '==' | '!=') expr
    | expr ('&&' | '||') expr
    | expr '?' expr ':' expr
    | expr '.' id
    | expr '[' expr ']'
    | expr '(' (expr (',' expr)*)? ')'
    | expr ('=' | '+=' | '-=' | '*=' | '/=' | '^=') expr (';')*?
    | expr '++' | expr '--'  (';')*?
    | '++' expr | '--' expr  (';')*?
    | id '=' expr (';')*?
    | id
    | INT
    | FLOAT
    | STRING
    | BOOL
    | 'null'
    | 'this'
    | 'new' id '(' (expr (',' expr)*)? ')' (';')*?
    | '(' expr ')' (';')*?;

id: ID;

path: STRING;

INT: [0-9]+;
FLOAT: [0-9]*'.'[0-9]+;
ID: [a-zA-Z_][a-zA-Z0-9_]*;
STRING: '"' .*? '"' | '\'' .*? '\'';
BOOL: 'true' | 'false';

WS: [ \t\u000C\r\n]+ -> skip;
COMMENT:            '/*' .*? '*/'    -> channel(HIDDEN);
LINE_COMMENT:       '//' ~[\r\n]*    -> channel(HIDDEN);