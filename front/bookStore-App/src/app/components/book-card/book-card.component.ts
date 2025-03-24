import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-book-card',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './book-card.component.html',
  styleUrls: ['./book-card.component.scss']
})
export class BookCardComponent implements OnInit {

  books: { titulo: string; preco: number; nota: number }[] = [];

  ngOnInit() {
    this.books = [
      { titulo: 'Aventuras Cósmicas', preco: 79.99, nota: 4 },
      { titulo: 'Angular para Iniciantes', preco: 59.90, nota: 5 },
      { titulo: 'O Senhor dos Códigos', preco: 99.50, nota: 4 },
      { titulo: 'Design de Sistemas', preco: 89.00, nota: 3 },
      { titulo: 'Refatoração Moderna', preco: 72.30, nota: 4 },
      { titulo: 'Clean Code', preco: 110.00, nota: 5 },
      { titulo: 'Padrões de Projeto', preco: 95.40, nota: 4 },
      { titulo: 'Desvendando APIs REST', preco: 65.90, nota: 3 },
      { titulo: 'JavaScript Avançado', preco: 83.70, nota: 4 },
      { titulo: 'Estrutura de Dados em C', preco: 78.80, nota: 5 },
      { titulo: 'A Arte de Programar', preco: 120.00, nota: 5 },
      { titulo: 'Banco de Dados para Web', preco: 69.90, nota: 3 },
      { titulo: 'Microserviços na Prática', preco: 92.00, nota: 4 },
      { titulo: 'Segurança da Informação', preco: 88.00, nota: 5 },
      { titulo: 'Machine Learning Fácil', preco: 105.00, nota: 4 }
    ];
  }
}
