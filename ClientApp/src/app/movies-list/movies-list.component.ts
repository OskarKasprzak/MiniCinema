import {Component, Inject, OnInit} from '@angular/core';
import {Movie} from './movie/movie.model';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-movies-list',
  templateUrl: './movies-list.component.html',
  styleUrls: ['./movies-list.component.css']
})
export class MoviesListComponent implements OnInit {
  public movies: Movie[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Movie[]>(baseUrl + 'movie').subscribe(result => {
      this.movies = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }



}
