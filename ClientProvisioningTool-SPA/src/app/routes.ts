import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AdminComponent } from './admin/admin.component';
import { FaqComponent } from './faq/faq.component';

// order is important, if wildcard is first nothing would ever link
// when OKTA tokens are implemented, add in an AuthGuard to prevent pages from being accessed without being logged in
export const appRoutes: Routes = [
    // path for top level route is blank because that would be the default home route
    // this blank path is not the same as the auth guard blank path
    { path: '', component: HomeComponent },
    { path: 'admin', component: AdminComponent },
    { path: 'faq', component: FaqComponent },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
