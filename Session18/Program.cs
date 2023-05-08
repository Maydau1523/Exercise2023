{
bool es_curp(const char* cadena) 
    return (strlen(cadena) == 18);
}

bool es_rfc(const char* cadena) {
    int longitud = strlen(cadena);
    return (longitud == 10 || longitud == 13);
}

int main() {
    char cadena[50];

    printf("Ingrese una cadena: ");
    scanf("%s", cadena);

    if (es_curp(cadena)) {
        printf("Es un CURP.\n");
    } else if (es_rfc(cadena)) {
        printf("Es un RFC.\n");
    } else {
        printf("No es ni un CURP ni un RFC.\n");
    }

    return 0;
}
