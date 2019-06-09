import { Movie } from './movie.model';
import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class Repository {
    movie: Movie;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        http.get<Movie>(baseUrl + 'api/sampleData/GetMovie')
            .subscribe(
                result => {
                    this.movie = result;
                },
                error => console.error(error));
    };
}
