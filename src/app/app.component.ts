import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Investigacion1';
  resultado;

  BBS(array: number[]): number[]{
    const tempArray = array;
    let volverAOrdenar = false;
    // Recorre el array
    for (let i = 0; i < tempArray.length - 1 ; i++) {
        // Comprueba si el primero es mayor que el segundo
        if (tempArray[i] > tempArray[i + 1]) {
            // Intercambia la primera posición por la segunda
            const primerNum = tempArray[i];
            const segundoNum = tempArray[i + 1];
            tempArray[i] = segundoNum;
            tempArray[i + 1] = primerNum;
            // Si debe volver a ordenarlo
            volverAOrdenar = true;
        }
    }
    // Vuelve a llamar al función
    if (volverAOrdenar) {
        this.BBS(tempArray);
    }
    // Retorna el array ordenado
    return tempArray;
  }
}
