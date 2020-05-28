import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { OverviewComponent } from './overview/overview.component';
import { SearchComponent } from './search/search.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    { path: 'overview', component: OverviewComponent, canActivate: [AuthGuard]},
    { path: 'search', component: SearchComponent, canActivate: [AuthGuard]},
    { path: '**', redirectTo: '', pathMatch: 'full'}
];
