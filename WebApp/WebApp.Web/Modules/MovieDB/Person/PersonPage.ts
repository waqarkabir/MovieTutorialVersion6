import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PersonGrid } from './PersonGrid';

export default function pageInit() {
    initFullHeightGridPage(new PersonGrid($('#GridDiv')).element);
}