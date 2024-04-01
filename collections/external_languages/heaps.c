#include <stdio.h>

int main()
{
    // taking about pointers here

    int age = 20; // now p contains the memory address of int age
    int *p = age;

    // creating a heap using c
    int *ptr;
    *ptr = (int*)malloc(sizeof(int));

    *ptr=20;


    return 0;
}