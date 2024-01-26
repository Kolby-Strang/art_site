<template>
  <div class="container-fluid">
    <div id="hero" class="row px-0 py-0">
      <div class="col-12 px-0">
        <img class="hero-img"
          src="https://yzcvxjdmcmvriilyesrf.supabase.co/storage/v1/object/public/images/within-the-hearts-of-humankind/1"
          alt="Gia Standing within wings made of knives">
      </div>
    </div>
    <div class="row">
      <div class="col-12 col-md-6">
        <p class="fs-1">Hi, I'm Gia</p>
        <p class="fs-5">I'm a Sculptor based in Boise, Idaho</p>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Provident dolores voluptas exercitationem repudiandae
          inventore cumque fugiat! Quaerat aspernatur molestias culpa omnis quae corporis incidunt consequatur laborum
          enim, voluptatem expedita repellendus.</p>
      </div>
      <div class="col-12 col-md-6 d-flex justify-content-center">
        <img class="img-fluid object-cover rounded"
          src="https://yzcvxjdmcmvriilyesrf.supabase.co/storage/v1/object/public/images/Gia" alt="A photo of Gia">
      </div>
    </div>
    <div v-if="newestSculpture.id" class="row bg-grey">
      <p class="fs-1">Check out my newest sculpture!</p>
      <div class="col-12 col-md-6 text-center">
        <p class="fs-2 text-secondary mb-0">{{ newestSculpture.name }}</p>
        <img class="img-fluid rounded" :src="newestSculpture.coverImg" :alt="'Photo of ' + newestSculpture.name">
      </div>
      <div class="col-12 col-md-6">
        <p class="fs-5">{{ newestSculpture.description }}</p>
      </div>
    </div>
  </div>
</template>

<script>
import { onMounted, ref } from 'vue'
import Pop from '../utils/Pop'
import { sculpturesService } from '../services/SculpturesService.js'

export default {
  setup() {
    // VARIABLES
    let newestSculpture = ref({})
    // FUNCTIONS
    async function getNewestSculpture() {
      try {
        newestSculpture.value = await sculpturesService.getNewestSculpture()
      } catch (err) {
        Pop.error(err)
      }
    }
    // LIFECYCLE
    onMounted(() => {
      getNewestSculpture()
    })
    return {
      newestSculpture
    }
  }
}
</script>

<style scoped lang="scss">
.hero-img {
  aspect-ratio: 16/7;
  object-fit: cover;
  object-position: center;
  width: 100%;
}
</style>
