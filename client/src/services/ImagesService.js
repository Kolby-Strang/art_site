import { Image } from "../models/Image"
import { api } from "./AxiosService"

class ImagesService {
    async getImagesBySculptureId(id) {
        const res = await api.get(`api/sculptures/${id}/images`)
        return res.data.map((pojo) => new Image(pojo))
    }

}

export const imagesService = new ImagesService()