grammar OwOLang;

script: 'OwO' ID function* EOF;

function
    : declare_new_variable
    | set_variable
    | declare_and_set_variable
    | loop_x_times
    | declare_new_type
    | print
    ;

print: 'sayz' expression;

loop_x_times: 'do dis' expression 'timez doez' function* 'endz';

declare_new_type: 'datsa' id (declare_new_variable | declare_and_set_variable)* 'datsall';

declare_new_variable: 'i can haz' id 'hoos race iz' type;

set_variable : expression 'iz nao' expression;
    
declare_and_set_variable : 'i can haz' id 'hoos race iz' type 'iz nao' expression;
    
expression
    : primitives
    | id
    | expression '^+^' expression
    | expression '^-^' expression
    | expression '^*^' expression
    | expression '^/^' expression
    | expression '^%^' expression
    | expression '^<^' expression
    | expression '^>^' expression
    | expression '^<=^' expression
    | expression '^>=^' expression
    | expression '^==^' expression
    | expression '^!=^' expression
    | expression '^&&^' expression
    | expression '^||^' expression
    | '^!^' expression
    | expression 'from' expression
    ;
    
type
    : 'numbah' // int
    | 'dottynumbah' // float
    | 'textz' // string
    | 'opinionz' // bool
    | 'idc' // any
    | id // custom type
    | 'lotz da' type // array
    ;
    
primitives 
    : int 
    | float 
    | string 
    | bool
    ;
    
id: ID;
int: INT;
float: FLOAT;
string: STRING;
bool: BOOL;

INT : [0-9]+;
FLOAT : [0-9]*'.'[0-9]+;
ID : [a-zA-Z_][a-zA-Z0-9_]*;
STRING : '^w^' .*? '^w^';
BOOL : 'yaya' | 'nah';

WS: [ \t\u000C\r\n]+ -> skip;
COMMENT:            '/*' .*? '*/'    -> channel(HIDDEN);
LINE_COMMENT:       '//' ~[\r\n]*    -> channel(HIDDEN);