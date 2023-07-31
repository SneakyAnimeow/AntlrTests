{
    c = 0;
    d = 100;
    
    if (c < d)
    {
        c = c + 1;
    }

    if(0 < c)
    {
        d = d - 1;
    }

    if(1 < c)
    {
        flag = 3;
    }else
    {
        flag = 4;
    }

    while(c < 200)
    {
        c = c + 1;
    }

    do
    {
        c = c - 1;
    }while(c < 0);

    while(flag < c)
    {
        c = c - 1;
        flag = flag + 1;
    }
}