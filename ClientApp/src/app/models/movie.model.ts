import { Studio } from './studio.model';
import { Rating } from './rating.model';

export class Movie {
    constructor(
        public movieId?: number,
        public name?: string,
        public category?: string,
        public decription?: string,
        public price?: number,
        public studio?: Studio,
        public ratings?: Rating[]

    ) { };
}
