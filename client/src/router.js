import { createRouter, createWebHashHistory } from 'vue-router'
import { authGuard } from '@bcwdev/auth0provider-client'

function loadPage(page) {
  return () => import(`./pages/${page}.vue`)
}

const routes = [
  {
    path: '/',
    name: 'Home',
    component: loadPage('HomePage')
  },
  {
    path: '/about',
    name: 'About',
    component: loadPage('AboutPage')
  },
  {
    path: '/admin',
    name: 'Admin',
    component: loadPage('AdminPage'),
    beforeEnter: authGuard
  },
  {
    path: '/sculptures',
    name: 'Sculptures',
    component: loadPage('SculpturesPage')
  },
  {
    path: '/artist-statement',
    name: 'ArtistStatement',
    component: loadPage('ArtistStatementPage')
  },
  {
    path: '/sculpture/:id',
    name: 'Sculpture',
    component: loadPage('SculpturePage')
  }
]

export const router = createRouter({
  linkActiveClass: 'router-link-active',
  linkExactActiveClass: 'router-link-exact-active',
  history: createWebHashHistory(),
  routes
})
