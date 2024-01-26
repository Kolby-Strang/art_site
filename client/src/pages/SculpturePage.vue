<template>
    <div class="container-fluid">
        <div class="row">
            <div class="col-12 col-md-6">
                <img v-if="images.length > 0" :src="sculpture.coverImg" :alt="`Picture of ${sculpture.name}`">
                <!-- TODO keep working here -->
            </div>
            <div class="col-12 col-md-6"></div>
        </div>
    </div>
</template>


<script>
import { onMounted, ref } from 'vue';
import Pop from '../utils/Pop';
import { sculpturesService } from '../services/SculpturesService';
import { imagesService } from '../services/ImagesService';
import { useRoute } from 'vue-router';

export default {
    setup() {
        // VARIABLES
        const sculpture = ref({})
        const images = ref([])
        const route = useRoute()
        // FUNCTIONS
        async function getThisSculpture() {
            try {
                sculpture.value = await sculpturesService.getSculptureById(route.params.id)
            } catch (err) {
                Pop.error(err)
            }
        }
        async function getThisImages() {
            try {
                images.value = await imagesService.getImagesBySculptureId(route.params.id)
            } catch (err) {
                Pop.error(err)
            }
        }
        // LIFECYCLE
        onMounted(() => {
            getThisSculpture()
            getThisImages()
        })
        return { sculpture, images }
    }
};
</script>


<style lang="scss" scoped></style>