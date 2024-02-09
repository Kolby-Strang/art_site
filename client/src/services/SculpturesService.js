import { Sculpture } from "../models/Sculpture"
import { logger } from "../utils/Logger"
import { api } from "./AxiosService"

class SculpturesService {
    async getNewestSculpture() {
        const res = await api.get('api/sculptures')
        res.data = res.data.map((pojo) => new Sculpture(pojo))
        const sculptures = res.data.sort((a, b) => b.id - a.id)
        return sculptures[0]
    }
    async getAllSculptures() {
        const res = await api.get('api/sculptures')
        let sculptures = res.data.map((pojo) => new Sculpture(pojo))
        return sculptures.reverse()
    }
    async getSculptureById(id) {
        const res = await api.get(`api/sculptures/${id}`)
        return new Sculpture(res.data)
    }
}

export const sculpturesService = new SculpturesService()