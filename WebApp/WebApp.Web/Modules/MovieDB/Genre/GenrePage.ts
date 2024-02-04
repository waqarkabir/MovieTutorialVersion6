import { initFullHeightGridPage } from '@serenity-is/corelib';
import { GenreGrid } from './GenreGrid';

export default function pageInit() {
    initFullHeightGridPage(new GenreGrid($('#GridDiv')).element);
}