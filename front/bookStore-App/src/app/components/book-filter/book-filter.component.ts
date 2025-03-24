import { CommonModule, NgClass } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-book-filter',
  standalone: true,
  imports: [NgClass, CommonModule, FormsModule],
  templateUrl: './book-filter.component.html',
  styleUrl: './book-filter.component.scss'
})
export class BookFilterComponent {

  categoriaSelecionada: string = 'Todos';
  precoMin!: number;
  precoMax!: number;
  anoMin!: number;
  anoMax!: number;

  autores: string[] = ['Autor A', 'Autor B', 'Autor C', 'Autor D'];
  categorias: string[] = ['Categoria A', 'Categoria B', 'Categoria C', 'Categoria D'];
  editoras: string[] = ['Editora A', 'Editora B', 'Editora C', 'Editora D'];

  notasSelecionadas: number[] = [];

  selecionarCategoria(categoria: string) {
    this.categoriaSelecionada = categoria;
    // Aqui você pode emitir um evento para atualizar os livros se quiser
  }

}
