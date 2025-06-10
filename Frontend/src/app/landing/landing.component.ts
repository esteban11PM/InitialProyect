import { Component, inject, OnInit } from '@angular/core';
import { TestConnectionService } from '../Services/test-connection.service';
import { Test } from '../Models/Test.model';


@Component({
  selector: 'app-landing',
  standalone: true,
  imports: [],
  templateUrl: './landing.component.html',
  styleUrl: './landing.component.css'
})
export class LandingComponent implements OnInit{
  testService = inject(TestConnectionService);

  dataTests: Test[] = [];

  ngOnInit(): void {
    this.testService.getAll().subscribe({
      next: (data) => {
        this.dataTests = data;
        console.log('Data:', this.dataTests);
      },
      error: (err) => {
        console.error('Error al obtener usuarios:', err);
      }
    });
  }
}
