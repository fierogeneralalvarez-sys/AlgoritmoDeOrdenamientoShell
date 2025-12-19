
import java.util.Random;
import java.util.Scanner;

public class ShellSort {

    static Random rnd = new Random();

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int[] arreglo = null;
        int opcion;

        do {
            System.out.println("===== MENU SHELLSORT =====");
            System.out.println("1 - Generar arreglo");
            System.out.println("2 - Ordenar arreglo (ShellSort)");
            System.out.println("3 - Salir");
            System.out.print("Selecciona una opción: ");

            if (!sc.hasNextInt()) {
                System.out.println("Opción inválida.");
                sc.next();
                continue;
            }

            opcion = sc.nextInt();

            switch (opcion) {
                case 1:
                    System.out.print("Ingresa el tamaño del arreglo: ");
                    if (!sc.hasNextInt()) {
                        System.out.println("Tamaño inválido.");
                        sc.next();
                        break;
                    }

                    int tamaño = sc.nextInt();

                    if (tamaño <= 0) {
                        System.out.println("El tamaño debe ser mayor a 0.");
                        break;
                    }

                    arreglo = new int[tamaño];
                    for (int i = 0; i < tamaño; i++) {
                        arreglo[i] = rnd.nextInt(100) + 1;
                    }

                    System.out.println("Arreglo generado:");
                    mostrarArreglo(arreglo);
                    break;

                case 2:
                    if (arreglo == null) {
                        System.out.println("Primero debes generar el arreglo.");
                        break;
                    }

                    shellSort(arreglo);
                    System.out.println("Arreglo ordenado:");
                    mostrarArreglo(arreglo);
                    break;

                case 3:
                    System.out.println("Saliendo...");
                    break;

                default:
                    System.out.println("Opción no válida.");
            }

            System.out.println();

        } while (opcion != 3);

        sc.close();
    }

    private static void shellSort(int[] arr) {
        int n = arr.length;

        for (int gap = n / 2; gap > 0; gap /= 2) {
            for (int i = gap; i < n; i++) {
                int temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap] > temp) {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }
        }
    }

    private static void mostrarArreglo(int[] arr) {
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i]);
            if (i < arr.length - 1)
                System.out.print(", ");
        }
        System.out.println();
    }
}
