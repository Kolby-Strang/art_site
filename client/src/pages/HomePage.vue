<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col-12 my-4 px-0 hero-container">
        <div class="d-flex justify-content-center align-items-center">
          <img class="gia-photo pe-3"
            src="https://img-cache.oppcdn.com/img/v1.0/s:67254/t:QkxBTksrVEVYVCtIRVJF/p:12/g:tl/o:2.5/a:50/q:90/960x960-SkvXFxuphccIfGVt.jpg/960x960/81eebc02331506f99349d552e2e1773a.jpg"
            alt="Gia Strang">
          <p class="fs-1">Hi, I'm Gia Strang</p>
        </div>
      </div>
    </div>
    <div v-for="artPiece in artPieces" class="row py-4 px-5">
      <div class="col-3">
        <img class="img-fluid" :src="artPiece.img" alt="">
      </div>
      <div class="col-4">
        <p>{{ artPiece.name }}</p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  setup() {
    // VARIABLES
    const artPieces = [
      {
        name: 'Toxic',
        img: 'https://img-cache.oppcdn.com/img/v1.0/s:67254/t:QkxBTksrVEVYVCtIRVJF/p:12/g:tl/o:2.5/a:50/q:90/2520x1220-cugvCr2YQxzfGPjv.jpg/810x1220/3db65d71ada7a189b3b396c3ef9921ae.jpg',
      },
      {
        name: 'Chaos Contained',
        img: 'https://img-cache.oppcdn.com/img/v1.0/s:67254/t:QkxBTksrVEVYVCtIRVJF/p:12/g:tl/o:2.5/a:50/q:90/2520x1220-9r9TSH31cU8gQdq3.jpg/810x1220/c67a33cdafd577a31a5c4f4b3b81f62c.jpg'
      },
      {
        name: 'Dahlia in Copper',
        img: 'https://img-cache.oppcdn.com/img/v1.0/s:67254/t:QkxBTksrVEVYVCtIRVJF/p:12/g:tl/o:2.5/a:50/q:90/984x588-elOYvNZ31VsOwRPA.jpg/784x588/dbb1cd8fcefb2bc59d205e7cc7bdffe4.jpg'
      }
    ]
    // FUNCTIONS

    // LIFECYCLE
    return {
      artPieces
    }
  }
}
</script>

<style scoped lang="scss">
.carousel-item {
  >div {
    >img {
      height: 100%;
      object-fit: cover;
      display: block;
    }
  }
}

.row:nth-child(2n) {
  background-color: rgba(255, 255, 255, 0.099);
}

.hero-container {
  display: flex;
  height: 60vh;
  justify-content: center;
  align-items: center;
  position: relative;
}

.gia-photo {
  height: 20rem;
  border-radius: 50%;
}
</style>
